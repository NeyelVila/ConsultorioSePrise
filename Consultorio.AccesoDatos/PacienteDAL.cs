using Consultorio.Entidades;
using MySql.Data.MySqlClient;
using System;

namespace Consultorio.AccesoDatos
{
    public class PacienteDAL
    {
        private ConexionMySQL conexion = new ConexionMySQL();

        public Paciente BuscarPorDNI(string dni)
        {
            Paciente paciente = null;
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM paciente WHERE DNI = @dni",
                conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@dni", dni);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    paciente = new Paciente
                    {
                        ID_Paciente = reader.GetInt32("ID_Paciente"),
                        DNI = reader.GetString("DNI"),
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Fecha_Nacimiento = reader.GetDateTime("Fecha_Nacimiento"),
                        Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? "" : reader.GetString("Telefono"),
                        Obra_Social = reader.IsDBNull(reader.GetOrdinal("Obra_Social")) ? "" : reader.GetString("Obra_Social")
                    };
                }
            }
            conexion.CerrarConexion();
            return paciente;
        }

        public int Registrar(Paciente paciente)
        {
            MySqlCommand cmd = new MySqlCommand(
                @"INSERT INTO paciente (DNI, Nombre, Apellido, Fecha_Nacimiento, Telefono, Obra_Social) 
                  VALUES (@DNI, @Nombre, @Apellido, @Fecha_Nacimiento, @Telefono, @Obra_Social);
                  SELECT LAST_INSERT_ID();", // Devuelve el ID del paciente recién creado
                conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@DNI", paciente.DNI);
            cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", paciente.Fecha_Nacimiento);
            cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
            cmd.Parameters.AddWithValue("@Obra_Social", paciente.Obra_Social);

            int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.CerrarConexion();
            return nuevoId;
        }
    }
}
