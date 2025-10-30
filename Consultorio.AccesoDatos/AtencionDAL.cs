using MySql.Data.MySqlClient;
using Consultorio.Entidades;
using System;
using System.Data;

namespace Consultorio.AccesoDatos
{
   public class AtencionDAL
    {
        private ConexionMySQL conexion = new ConexionMySQL();

        public int Registrar(Atencion atencion)
        {
            MySqlCommand cmd = new MySqlCommand(
                @"INSERT INTO atencion (ID_Historia_Clinica, ID_Turno, Fecha_Atencion, Motivo_Consulta, Diagnostico, Tratamiento, ID_Profesional) 
                  VALUES (@ID_Historia_Clinica, @ID_Turno, NOW(), @Motivo_Consulta, @Diagnostico, @Tratamiento, @ID_Profesional);
                  SELECT LAST_INSERT_ID();",
                conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@ID_Historia_Clinica", atencion.ID_Historia_Clinica);
            cmd.Parameters.AddWithValue("@ID_Turno", atencion.ID_Turno);
            cmd.Parameters.AddWithValue("@Motivo_Consulta", atencion.Motivo_Consulta);
            cmd.Parameters.AddWithValue("@Diagnostico", atencion.Diagnostico);
            cmd.Parameters.AddWithValue("@Tratamiento", atencion.Tratamiento);
            cmd.Parameters.AddWithValue("@ID_Profesional", atencion.ID_Profesional);

            int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.CerrarConexion();
            return nuevoId;
        }

        public DataTable ListarPorHistoriaID(int idHistoria)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(
                @"SELECT 
                    Fecha_Atencion, 
                    Motivo_Consulta, 
                    Diagnostico, 
                    Tratamiento,
                    CONCAT(p.Apellido, ', ', p.Nombre) AS Profesional 
                  FROM atencion a
                  INNER JOIN profesional p ON a.ID_Profesional = p.ID_Profesional
                  WHERE ID_Historia_Clinica = @idHistoria
                  ORDER BY Fecha_Atencion DESC;",
                conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@idHistoria", idHistoria);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.CerrarConexion();
            return dt;
        }
    }
}
