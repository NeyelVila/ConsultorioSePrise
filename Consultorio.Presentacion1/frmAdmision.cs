using Consultorio.LogicaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Consultorio.Presentacion1
{
    public partial class frmAdmision : Form
    {
        private TurnoBLL turnoBLL = new TurnoBLL();
        public frmAdmision()
        {
            InitializeComponent();
            dtpFechaAdmision.Value = DateTime.Today; // Establece la fecha de hoy por defecto

        }
        // --- EVENTOS DEL FORMULARIO ---
        private void frmAdmision_Load(object sender, EventArgs e)
        {
            dtpFechaAdmision.Value = DateTime.Today; // Establece la fecha de hoy por defecto
            CargarTurnosConfirmados(); // Carga la lista al inicio
        }
        private void dtpFechaAdmision_ValueChanged(object sender, EventArgs e)
        {
            CargarTurnosConfirmados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTurnosConfirmados();
        }
        private void dgvTurnosDelDia_SelectionChanged(object sender, EventArgs e)
        {
            // Habilita el botón "Acreditar" si hay al menos una fila seleccionada
            btnAcreditar.Enabled = dgvTurnosDelDia.SelectedRows.Count > 0;
        }

        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            if (dgvTurnosDelDia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un turno para acreditar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos el ID_Turno de la fila seleccionada
            // Asumimos que la columna ID_Turno existe y es la primera o tiene un nombre conocido
            int idTurno = Convert.ToInt32(dgvTurnosDelDia.SelectedRows[0].Cells["ID_Turno"].Value);
            string pacienteNombre = dgvTurnosDelDia.SelectedRows[0].Cells["PacienteNombreCompleto"].Value.ToString();

            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirma la acreditación del paciente '{pacienteNombre}' para su turno?",
                "Confirmar Acreditación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    turnoBLL.AcreditarPaciente(idTurno);
                    MessageBox.Show($"Paciente '{pacienteNombre}' acreditado correctamente. Enviado a sala de espera.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTurnosConfirmados(); // Recarga la grilla para mostrar los cambios
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al acreditar paciente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // --- MÉTODOS AUXILIARES ---
        private void CargarTurnosConfirmados()
        {
            try
            {
                DataTable turnos = turnoBLL.ListarTurnosParaAdmision(dtpFechaAdmision.Value);
                dgvTurnosDelDia.DataSource = turnos;

                // Configurar DataGridView (opcional, para mejor visualización)
                if (dgvTurnosDelDia.Columns.Contains("ID_Turno"))
                    dgvTurnosDelDia.Columns["ID_Turno"].Visible = false;
                if (dgvTurnosDelDia.Columns.Contains("ID_Paciente"))
                    dgvTurnosDelDia.Columns["ID_Paciente"].Visible = false;
                if (dgvTurnosDelDia.Columns.Contains("ID_Profesional"))
                    dgvTurnosDelDia.Columns["ID_Profesional"].Visible = false;

                // Renombrar columnas para la vista del usuario
                if (dgvTurnosDelDia.Columns.Contains("PacienteDNI"))
                    dgvTurnosDelDia.Columns["PacienteDNI"].HeaderText = "DNI Paciente";
                if (dgvTurnosDelDia.Columns.Contains("PacienteNombreCompleto"))
                    dgvTurnosDelDia.Columns["PacienteNombreCompleto"].HeaderText = "Paciente";
                if (dgvTurnosDelDia.Columns.Contains("ProfesionalNombreCompleto"))
                    dgvTurnosDelDia.Columns["ProfesionalNombreCompleto"].HeaderText = "Profesional";

                // Deshabilita el botón Acreditar si no hay turnos
                btnAcreditar.Enabled = turnos.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar turnos para admisión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
