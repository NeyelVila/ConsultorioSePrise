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
    public partial class frmLogin : Form
    {
        private PersonalAdminBLL adminBLL = new PersonalAdminBLL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            try
            {
                PersonalAdmin adminValidado = adminBLL.IniciarSesion(usuario, contrasena);

                if (adminValidado != null)
                {
                    // Login exitoso
                    lblError.Visible = false;

                    // --- INICIO DE LA MODIFICACIÓN ---
                    // Redirección basada en Rol
                    if (adminValidado.Rol == "Admin")
                    {
                        // Si es Admin, va al Menú Principal
                        frmMenuPrincipal menu = new frmMenuPrincipal();
                        menu.Show();
                        this.Hide();
                    }
                    else if (adminValidado.Rol == "Medico" && adminValidado.ID_Profesional_Asociado != null)
                    {
                        // Si es Medico, va directo a su consultorio
                        // Pasamos el ID del profesional y su nombre al formulario
                        frmConsultorioMedico consultorio = new frmConsultorioMedico(
                            adminValidado.ID_Profesional_Asociado.Value,
                            adminValidado.Nombre
                        );
                        consultorio.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Rol no reconocido o médico no asociado
                        lblError.Text = "Rol de usuario no configurado correctamente.";
                        lblError.Visible = true;
                    }
                    // --- FIN DE LA MODIFICACIÓN ---
                }
                else
                {
                    // Falla de login
                    lblError.Text = "Usuario y/o contraseña incorrecta";
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                lblError.Visible = true;
            }
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = chkMostrarContrasena.Checked ? '\0' : '*';
        }
    }
}
