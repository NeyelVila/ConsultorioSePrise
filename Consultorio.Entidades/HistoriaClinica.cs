using System;

namespace Consultorio.Entidades
{
    public class HistoriaClinica
    {
        public int ID_Historia_Clinica { get; set; }
        public int ID_Paciente { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Notas_Generales { get; set; }
    }
}