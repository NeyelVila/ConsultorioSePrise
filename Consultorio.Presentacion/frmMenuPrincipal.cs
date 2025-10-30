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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void btnGestionTurnos_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de turnos
            frmGestionTurnos formTurnos = new frmGestionTurnos();
            formTurnos.ShowDialog(); // ShowDialog() bloquea el menú hasta que se cierre
        }

        private void btnGestionPacientes_Click(object sender, EventArgs e)
        {
            // Aquí crearías y mostrarías un frmGestionPacientes (no cubierto en esta guía)
            MessageBox.Show("Formulario de Pacientes en construcción.");
        }

        private void btnGestionProfesionales_Click(object sender, EventArgs e)
        {
            // Aquí crearías y mostrarías un frmGestionProfesionales (no cubierto en esta guía)
            MessageBox.Show("Formulario de Profesionales en construcción.");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerramos este formulario y volvemos a mostrar el login
            // Necesitamos una referencia al formulario de login
            // Una mejor forma es manejar esto en Program.cs, pero esto es más simple:
            Application.Restart();
        }
    }
}
