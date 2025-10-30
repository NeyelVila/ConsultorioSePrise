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
                    frmMenuPrincipal menu = new frmMenuPrincipal();
                    menu.Show();
                    this.Hide(); // Ocultamos el login
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

