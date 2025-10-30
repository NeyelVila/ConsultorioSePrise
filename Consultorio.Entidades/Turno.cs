using System;
namespace Consultorio.Entidades
{
    public class Turno
    {
        public int ID_Turno { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Estado { get; set; }
        public bool Es_Sobreturno { get; set; }
        public int ID_Paciente { get; set; }
        public int ID_Profesional { get; set; }
    }
}