using Consultorio.AccesoDatos; // La biblioteca de clases
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Consultorio.Presentacion1
{
    public partial class frmConfiguracionDB : Form
    {
        public frmConfiguracionDB()
        {
            InitializeComponent();
            // Valores por defecto para ayudar al usuario
            txtServidor.Text = "127.0.0.1";
            txtBaseDatos.Text = "db_consultorio_seprise";
            txtUsuarioDB.Text = "root";
        }

        private void btnProbarYGuardar_Click(object sender, EventArgs e)
        {
            // 1. Recolectamos los datos
            string servidor = txtServidor.Text.Trim();
            string baseDatos = txtBaseDatos.Text.Trim();
            string usuario = txtUsuarioDB.Text.Trim();
            string password = txtPasswordDB.Text;

            // 2. Construimos la cadena
            string connectionStringGenerada = $"Server={servidor};Database={baseDatos};Uid={usuario};Pwd={password};";

            // 3. Probamos la conexión
            try
            {
                using (MySqlConnection testConnection = new MySqlConnection(connectionStringGenerada))
                {
                    testConnection.Open(); // Si esto no lanza excepción, la conexión es válida
                }

                // 4. ¡ÉXITO! Guardamos la cadena en la clase estática
                ConfiguracionConexion.ConnectionString = connectionStringGenerada;

                MessageBox.Show("Conexión establecida y guardada con éxito.", "Configuración Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Cerramos este formulario e indicamos que todo salió OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos:\n" + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // No cerramos el formulario, el usuario debe corregir los datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
