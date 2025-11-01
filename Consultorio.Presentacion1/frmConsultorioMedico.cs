using Consultorio.Entidades;
using Consultorio.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.Presentacion1
{
    public partial class frmConsultorioMedico : Form
    {
        private Form loginform;
        // --- Propiedades del Médico Logueado ---
        private int medicoID;
        private string medicoNombre;

        // --- BLLs (Lógica de Negocio) ---
        private TurnoBLL turnoBLL = new TurnoBLL();
        private HistoriaClinicaBLL hcBLL = new HistoriaClinicaBLL();
        private AtencionBLL atencionBLL = new AtencionBLL();

        // --- Estado Actual ---
        private DataRow pacienteEnConsulta = null; // Guardará los datos del paciente actual
        private HistoriaClinica hcActual = null; // Guardará la HC del paciente actual
        private int turnoEnConsultaID = 0;

        // --- CONSTRUCTOR MODIFICADO ---
        // Lo llamamos desde frmLogin
        public frmConsultorioMedico(int idProfesional, string nombreProfesional, Form login)
        {
            InitializeComponent();
            this.medicoID = idProfesional;
            this.medicoNombre = nombreProfesional;
            this.loginform = login;
        }
        // --- EVENTO LOAD (Al abrir el formulario) ---
        private void frmConsultorioMedico_Load(object sender, EventArgs e)
        {
            lblBienvenidoMedico.Text = $"Bienvenido, {this.medicoNombre}";
            // Configuramos el estado inicial de la UI
            ManejarEstadoUI(false);
            // Buscamos si ya había un paciente "En Consulta"
            RevisarPacienteEnConsulta();
            // Cargamos la sala de espera
            CargarSalaDeEspera();
        }

        // --- EVENTOS DE BOTONES ---
        private void btnActualizarEspera_Click(object sender, EventArgs e)
        {
            CargarSalaDeEspera();
        }

        private void btnLlamarSiguiente_Click(object sender, EventArgs e)
        {
            if (pacienteEnConsulta != null)
            {
                MessageBox.Show("Ya tiene un paciente en consulta. Debe finalizar la atención actual antes de llamar a otro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvSalaEspera.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un paciente de la sala de espera para llamar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtenemos los datos del paciente de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvSalaEspera.SelectedRows[0];
                int idTurno = Convert.ToInt32(filaSeleccionada.Cells["ID_Turno"].Value);
                int idPaciente = Convert.ToInt32(filaSeleccionada.Cells["ID_Paciente"].Value);

                // 1. Cambiamos el estado del turno a "En Consulta"
                turnoBLL.LlamarPaciente(idTurno);

                // 2. Guardamos los datos del paciente en la variable de estado
                // Usamos .Cells en lugar de .Rows[0].Cells porque ya tenemos la fila
                pacienteEnConsulta = (filaSeleccionada.DataBoundItem as DataRowView).Row;
                turnoEnConsultaID = idTurno;

                // 3. Cargamos la Historia Clínica
                hcActual = hcBLL.ObtenerOHCrearPorPacienteID(idPaciente);

                // 4. Actualizamos la UI
                CargarDatosPacienteEnConsulta();
                CargarHistorial();
                CargarSalaDeEspera(); // Recargamos la sala (el paciente ya no debe estar)
                ManejarEstadoUI(true); // Habilitamos el panel de consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llamar al paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarAtencion_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtMotivoConsulta.Text) || string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                MessageBox.Show("Debe ingresar al menos el Motivo de Consulta y el Diagnóstico.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Creamos el objeto Atencion
                Atencion nuevaAtencion = new Atencion
                {
                    ID_Historia_Clinica = hcActual.ID_Historia_Clinica,
                    ID_Turno = this.turnoEnConsultaID,
                    ID_Profesional = this.medicoID,
                    Motivo_Consulta = txtMotivoConsulta.Text.Trim(),
                    Diagnostico = txtDiagnostico.Text.Trim(),
                    Tratamiento = txtTratamiento.Text.Trim()
                };

                // 2. Registramos la atención
                atencionBLL.Registrar(nuevaAtencion);

                // 3. Finalizamos el turno (Estado = 'Atendido')
                turnoBLL.FinalizarAtencion(this.turnoEnConsultaID);

                MessageBox.Show("Atención guardada y finalizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Limpiamos y reseteamos la UI
                LimpiarPanelConsulta();
                ManejarEstadoUI(false);
                CargarSalaDeEspera(); // Actualizamos la sala por si llegó alguien más
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la atención: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            loginform.Show(); // Mostramos el formulario de login nuevamente
            this.Close(); // Cerramos el consultorio    
        }
        // --- MÉTODOS AUXILIARES (Helpers) ---

        // Revisa si el médico dejó un paciente en consulta al cerrar sesión
        private void RevisarPacienteEnConsulta()
        {
            try
            {
                DataTable dt = turnoBLL.ObtenerPacienteEnConsulta(DateTime.Today, this.medicoID);
                if (dt.Rows.Count > 0)
                {
                    // Había un paciente en consulta, cargamos sus datos
                    pacienteEnConsulta = dt.Rows[0];
                    turnoEnConsultaID = Convert.ToInt32(pacienteEnConsulta["ID_Turno"]);
                    int idPaciente = Convert.ToInt32(pacienteEnConsulta["ID_Paciente"]);

                    hcActual = hcBLL.ObtenerOHCrearPorPacienteID(idPaciente);

                    CargarDatosPacienteEnConsulta();
                    CargarHistorial();
                    ManejarEstadoUI(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al revisar consultas pendientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarSalaDeEspera()
        {
            try
            {
                dgvSalaEspera.DataSource = turnoBLL.ListarSalaDeEspera(DateTime.Today, this.medicoID);
                ConfigurarColumnasSalaEspera();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la sala de espera: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosPacienteEnConsulta()
        {
            if (pacienteEnConsulta != null)
            {
                lblPacienteNombre.Text = $"Paciente: {pacienteEnConsulta["Paciente"]}";
                lblPacienteDNI.Text = $"DNI: {pacienteEnConsulta["DNI"]}";
                lblPacienteHoraTurno.Text = $"Turno: {Convert.ToDateTime(pacienteEnConsulta["Hora"].ToString()).ToString("HH:mm")} hs";
            }
        }

        private void CargarHistorial()
        {
            try
            {
                if (hcActual != null)
                {
                    dgvHistorial.DataSource = atencionBLL.ListarPorHistoriaID(hcActual.ID_Historia_Clinica);
                    ConfigurarColumnasHistorial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el historial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpia el formulario después de una consulta
        private void LimpiarPanelConsulta()
        {
            pacienteEnConsulta = null;
            hcActual = null;
            turnoEnConsultaID = 0;

            lblPacienteNombre.Text = "Paciente: -";
            lblPacienteDNI.Text = "DNI: -";
            lblPacienteHoraTurno.Text = "Turno: -";

            txtMotivoConsulta.Text = "";
            txtDiagnostico.Text = "";
            txtTratamiento.Text = "";

            dgvHistorial.DataSource = null;
        }

        // Habilita/Deshabilita los paneles
        private void ManejarEstadoUI(bool enConsulta)
        {
            // Panel de consulta
            gbPacienteActual.Enabled = enConsulta;
            gbHistorial.Enabled = enConsulta;
            btnGuardarAtencion.Enabled = enConsulta;

            // Panel de sala de espera
            dgvSalaEspera.Enabled = !enConsulta;
            btnLlamarSiguiente.Enabled = !enConsulta;
        }

        // --- Configuración de Grillas (Opcional pero recomendado) ---
        private void ConfigurarColumnasSalaEspera()
        {
            if (dgvSalaEspera.Columns.Contains("ID_Turno"))
                dgvSalaEspera.Columns["ID_Turno"].Visible = false;
            if (dgvSalaEspera.Columns.Contains("ID_Paciente"))
                dgvSalaEspera.Columns["ID_Paciente"].Visible = false;

            if (dgvSalaEspera.Columns.Contains("Hora"))
                dgvSalaEspera.Columns["Hora"].DefaultCellStyle.Format = "HH:mm";

            if (dgvSalaEspera.Columns.Contains("Es_Sobreturno"))
                dgvSalaEspera.Columns["Es_Sobreturno"].HeaderText = "Sobreturno";
        }

        private void ConfigurarColumnasHistorial()
        {
            if (dgvHistorial.Columns.Contains("Fecha_Atencion"))
                dgvHistorial.Columns["Fecha_Atencion"].HeaderText = "Fecha";
            if (dgvHistorial.Columns.Contains("Motivo_Consulta"))
                dgvHistorial.Columns["Motivo_Consulta"].HeaderText = "Motivo";
        }

        // Esto evita que el usuario cierre el formulario con la 'X' 
        // y nos obliga a usar el botón "Cerrar Sesión"
        private void frmConsultorioMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancela el cierre
                MessageBox.Show("Por favor, use el botón 'Cerrar Sesión' para salir.", "Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
