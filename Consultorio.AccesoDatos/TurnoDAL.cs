using Consultorio.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Consultorio.AccesoDatos
{
    public class TurnoDAL
    {
        private ConexionMySQL conexion = new ConexionMySQL();

        public List<Turno> ListarPorFechaYProfesional(DateTime fecha, int idProfesional)
        {
            List<Turno> lista = new List<Turno>();
            MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM turno WHERE Fecha = @fecha AND ID_Profesional = @idProfesional AND Estado <> 'Cancelado' ORDER BY Hora",
                conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@fecha", fecha.Date);
            cmd.Parameters.AddWithValue("@idProfesional", idProfesional);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Turno
                    {
                        ID_Turno = reader.GetInt32("ID_Turno"),
                        Fecha = reader.GetDateTime("Fecha"),
                        Hora = reader.GetTimeSpan("Hora"),
                        Estado = reader.GetString("Estado"),
                        Es_Sobreturno = reader.GetBoolean("Es_Sobreturno"),
                        ID_Paciente = reader.GetInt32("ID_Paciente"),
                        ID_Profesional = reader.GetInt32("ID_Profesional")
                    });
                }
            }
            conexion.CerrarConexion();
            return lista;
        }

        public int Registrar(Turno turno)
        {
            MySqlCommand cmd = new MySqlCommand(
                @"INSERT INTO turno (Fecha, Hora, Estado, Es_Sobreturno, ID_Paciente, ID_Profesional) 
                  VALUES (@Fecha, @Hora, @Estado, @Es_Sobreturno, @ID_Paciente, @ID_Profesional);
                  SELECT LAST_INSERT_ID();",
                conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@Fecha", turno.Fecha);
            cmd.Parameters.AddWithValue("@Hora", turno.Hora);
            cmd.Parameters.AddWithValue("@Estado", turno.Estado);
            cmd.Parameters.AddWithValue("@Es_Sobreturno", turno.Es_Sobreturno);
            cmd.Parameters.AddWithValue("@ID_Paciente", turno.ID_Paciente);
            cmd.Parameters.AddWithValue("@ID_Profesional", turno.ID_Profesional);

            int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.CerrarConexion();
            return nuevoId;
        }
        public DataTable ListarTurnosConDatosParaAdmision(DateTime fecha, string estado)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(
            @"SELECT 
            t.ID_Turno,
            t.Fecha,
            -- MODIFICACIÓN AQUÍ: Formatear la hora directamente en SQL
            DATE_FORMAT(t.Hora, '%H:%i') AS Hora, -- Convertimos TIME a VARCHAR (HH:MM)
            t.Estado,
            t.Es_Sobreturno,
            p.ID_Paciente,
            p.DNI AS PacienteDNI,
            CONCAT(p.Apellido, ', ', p.Nombre) AS PacienteNombreCompleto,
            prof.ID_Profesional,
            CONCAT(prof.Apellido, ', ', prof.Nombre) AS ProfesionalNombreCompleto,
            e.Nombre AS Especialidad
            FROM turno t
            INNER JOIN paciente p ON t.ID_Paciente = p.ID_Paciente
            INNER JOIN profesional prof ON t.ID_Profesional = prof.ID_Profesional
            INNER JOIN especialidad e ON prof.ID_Especialidad = e.ID_Especialidad
            WHERE t.Fecha = @fecha AND t.Estado = @estado
            ORDER BY t.Hora ASC;",
        conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@fecha", fecha.Date);
            cmd.Parameters.AddWithValue("@estado", estado);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CerrarConexion();
            return dt;
        }

        public void ActualizarEstadoTurno(int idTurno, string nuevoEstado)
        {
            MySqlCommand cmd = new MySqlCommand(
                "UPDATE turno SET Estado = @nuevoEstado WHERE ID_Turno = @idTurno",
                conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
            cmd.Parameters.AddWithValue("@idTurno", idTurno);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable ListarTurnosPorEstadoYProfesional(DateTime fecha, int idProfesional, string estado)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(
            @"SELECT 
            t.ID_Turno,
            -- MODIFICACIÓN AQUÍ: Formatear la hora directamente en SQL
            DATE_FORMAT(t.Hora, '%H:%i') AS Hora, -- Convertimos TIME a VARCHAR (HH:MM)
            p.ID_Paciente,
            CONCAT(p.Apellido, ', ', p.Nombre) AS Paciente,
            p.DNI,
            t.Es_Sobreturno
            FROM turno t
            INNER JOIN paciente p ON t.ID_Paciente = p.ID_Paciente
            WHERE t.Fecha = @fecha 
            AND t.ID_Profesional = @idProfesional 
            AND t.Estado = @estado
            ORDER BY t.Hora ASC;",
        conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@fecha", fecha.Date);
            cmd.Parameters.AddWithValue("@idProfesional", idProfesional);
            cmd.Parameters.AddWithValue("@estado", estado);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CerrarConexion();
            return dt;
        }
    }
}
