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

namespace Consultorio.Presentacion
{
    public partial class frmGestionTurnos : Form
    {
        // Instancias de todas las capas de negocio que usaremos
        private PacienteBLL pacienteBLL = new PacienteBLL();
        private EspecialidadBLL especialidadBLL = new EspecialidadBLL();
        private ProfesionalBLL profesionalBLL = new ProfesionalBLL();
        private TurnoBLL turnoBLL = new TurnoBLL();

        // Variable para guardar el paciente que estamos manejando
        private Paciente pacienteActual = null;
        public frmGestionTurnos()
        {
            InitializeComponent();
        }
        // ---- EVENTO LOAD: Se ejecuta 1ro al abrir el form ----
        private void frmGestionTurnos_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            CargarEspecialidades();
        }

        // ---- EVENTOS DE CLIC ----
        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarDNI.Text.Trim();
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Debe ingresar un DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                pacienteActual = pacienteBLL.BuscarPorDNI(dni);

                if (pacienteActual != null)
                {
                    // Paciente ENCONTRADO
                    CargarDatosPaciente(pacienteActual);
                    HabilitarCamposPaciente(false); // Bloquear campos
                    HabilitarPanelTurno(true);      // Habilitar panel de turno
                }
                else
                {
                    // Paciente NO encontrado
                    MessageBox.Show("Paciente no encontrado. Puede registrar sus datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposPaciente(false); // Limpiar pero dejar DNI
                    HabilitarCamposPaciente(true);  // Habilitar para carga
                    HabilitarPanelTurno(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            // Lógica para guardar un NUEVO paciente
            try
            {
                Paciente nuevoPaciente = new Paciente
                {
                    DNI = txtBuscarDNI.Text.Trim(),
                    Nombre = txtNombreCompleto.Text.Trim(),
                    Apellido = "", // Deberías agregar un campo Apellido
                    Fecha_Nacimiento = dtpFechaNacimiento.Value,
                    Telefono = txtTelefono.Text.Trim(),
                    Obra_Social = txtObraSocial.Text.Trim()
                };

                pacienteActual = pacienteBLL.Registrar(nuevoPaciente);
                MessageBox.Show($"Paciente {pacienteActual.Nombre} registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HabilitarCamposPaciente(false);
                HabilitarPanelTurno(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (pacienteActual == null || cmbProfesional.SelectedValue == null || cmbHorarios.SelectedItem == null)
                {
                    throw new Exception("Debe completar todos los datos: Paciente, Profesional y Horario.");
                }

                Turno nuevoTurno = new Turno
                {
                    ID_Paciente = pacienteActual.ID_Paciente,
                    ID_Profesional = (int)cmbProfesional.SelectedValue,
                    Fecha = dtpFechaTurno.Value.Date,
                    Hora = TimeSpan.Parse(cmbHorarios.SelectedItem.ToString()),
                    Es_Sobreturno = chkEsSobreturno.Checked
                };

                turnoBLL.RegistrarTurno(nuevoTurno);

                MessageBox.Show("Turno registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAgenda(); // Recargar la grilla y horarios
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        // ---- EVENTOS DE CAMBIO (Combos y Fecha) ----
        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar profesionales cuando cambia la especialidad
            if (cmbEspecialidad.SelectedValue != null && cmbEspecialidad.SelectedValue is int)
            {
                int idEspecialidad = (int)cmbEspecialidad.SelectedValue;
                CargarProfesionales(idEspecialidad);
            }
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar agenda cuando cambia el profesional
            CargarAgenda();
        }

        private void dtpFechaTurno_ValueChanged(object sender, EventArgs e)
        {
            // Cargar agenda cuando cambia la fecha
            CargarAgenda();
        }


        // ---- MÉTODOS DE AYUDA (Helpers) ----
        private void CargarEspecialidades()
        {
            try
            {
                cmbEspecialidad.DataSource = especialidadBLL.ListarTodas();
                cmbEspecialidad.DisplayMember = "Nombre";
                cmbEspecialidad.ValueMember = "ID_Especialidad";
                cmbEspecialidad.SelectedIndex = -1; // Desseleccionar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProfesionales(int idEspecialidad)
        {
            try
            {
                cmbProfesional.DataSource = profesionalBLL.ListarPorEspecialidad(idEspecialidad);
                cmbProfesional.DisplayMember = "NombreCompleto";
                cmbProfesional.ValueMember = "ID_Profesional";
                cmbProfesional.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarAgenda()
        {
            // Este método carga la grilla (dgv) Y el combo de horarios
            if (cmbProfesional.SelectedValue == null) return;

            int idProfesional = (int)cmbProfesional.SelectedValue;
            DateTime fecha = dtpFechaTurno.Value.Date;

            try
            {
                // 1. Cargar Grilla
                var turnosOcupados = turnoBLL.ListarPorFechaYProfesional(fecha, idProfesional);
                dgvTurnosDelDia.DataSource = turnosOcupados;
                // Aquí podrías configurar las columnas del DataGridView...

                // 2. Cargar Horarios Disponibles
                CargarHorariosDisponibles(turnosOcupados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHorariosDisponibles(List<Turno> turnosOcupados)
        {
            cmbHorarios.Items.Clear();
            // Simulación de horarios de 09:00 a 18:00, cada 15 min.
            TimeSpan horaInicio = new TimeSpan(9, 0, 0);
            TimeSpan horaFin = new TimeSpan(18, 0, 0);
            TimeSpan intervalo = new TimeSpan(0, 15, 0); // Asumimos 15 min

            // Aquí deberías usar la "Duracion_Minima_Turno" de la especialidad

            TimeSpan horaActual = horaInicio;
            while (horaActual < horaFin)
            {
                // Si no hay un turno ocupado en esta hora...
                if (!turnosOcupados.Any(t => t.Hora == horaActual && !t.Es_Sobreturno))
                {
                    cmbHorarios.Items.Add(horaActual.ToString(@"hh\:mm"));
                }
                horaActual = horaActual.Add(intervalo);
            }
        }

        private void CargarDatosPaciente(Paciente p)
        {
            txtNombreCompleto.Text = $"{p.Nombre} {p.Apellido}";
            dtpFechaNacimiento.Value = p.Fecha_Nacimiento;
            txtTelefono.Text = p.Telefono;
            txtObraSocial.Text = p.Obra_Social;
        }

        // Métodos para limpiar y habilitar/deshabilitar controles
        private void LimpiarFormulario()
        {
            pacienteActual = null;
            LimpiarCamposPaciente(true);
            HabilitarCamposPaciente(false); // Deshabilitados al inicio
            txtBuscarDNI.Enabled = true;
            btnBuscarDNI.Enabled = true;
            HabilitarPanelTurno(false);
        }

        private void LimpiarCamposPaciente(bool limpiarDNI)
        {
            if (limpiarDNI) txtBuscarDNI.Text = "";
            txtNombreCompleto.Text = "";
            txtTelefono.Text = "";
            txtObraSocial.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void HabilitarCamposPaciente(bool habilitar)
        {
            txtNombreCompleto.ReadOnly = !habilitar;
            txtTelefono.ReadOnly = !habilitar;
            txtObraSocial.ReadOnly = !habilitar;
            dtpFechaNacimiento.Enabled = habilitar;
            btnRegistrarPaciente.Enabled = habilitar;
        }

        private void HabilitarPanelTurno(bool habilitar)
        {
            // El GroupBox se llama 'groupBoxTurno' o similar
            // groupBoxTurno.Enabled = habilitar;
            dtpFechaTurno.Enabled = habilitar;
            cmbEspecialidad.Enabled = habilitar;
            cmbProfesional.Enabled = habilitar;
            cmbHorarios.Enabled = habilitar;
            chkEsSobreturno.Enabled = habilitar;
            btnConfirmarTurno.Enabled = habilitar;
            dgvTurnosDelDia.DataSource = null;
        }
    }
}
