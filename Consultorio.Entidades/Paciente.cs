using System;
namespace Consultorio.Entidades
{
    public class Paciente
    {
        public int ID_Paciente { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Obra_Social { get; set; }
    }
}