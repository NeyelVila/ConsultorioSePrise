using MySql.Data.MySqlClient;
using Consultorio.Entidades;

namespace Consultorio.AccesoDatos
{
    public class PersonalAdminDAL
    {
        private ConexionMySQL conexion = new ConexionMySQL();

        public PersonalAdmin ValidarLogin(string usuario, string contrasena)
        {
            PersonalAdmin admin = null;
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM personal_admin WHERE Usuario = @user AND Contrasena = @pass",
                conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Parameters.AddWithValue("@pass", contrasena); // Recordatorio: ¡Hashear esto en producción!

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    admin = new PersonalAdmin
                    {
                        ID_Personal = reader.GetInt32("ID_Personal"),
                        Usuario = reader.GetString("Usuario"),
                        Nombre = reader.GetString("Nombre"),
                        Rol = reader.GetString("Rol"),
                        // Añadimos la lectura del nuevo campo
                        ID_Profesional_Asociado = reader.IsDBNull(reader.GetOrdinal("ID_Profesional_Asociado"))
                                                    ? (int?)null
                                                    : reader.GetInt32("ID_Profesional_Asociado")
                    };
                }
            }
            conexion.CerrarConexion();
            return admin;
        }
    }
}