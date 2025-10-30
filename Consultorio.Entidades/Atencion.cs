using System;

namespace Consultorio.Entidades
{
    public class Atencion
    {
        public int ID_Atencion { get; set; }
        public int ID_Historia_Clinica { get; set; }
        public int ID_Turno { get; set; }
        public DateTime Fecha_Atencion { get; set; }
        public string Motivo_Consulta { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public int ID_Profesional { get; set; } // Añadir para trazabilidad si se desvincula del turno
    }
}