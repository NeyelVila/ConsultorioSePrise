namespace Consultorio.Entidades
{
    // En Consultorio.Entidades/Profesional.cs
    public class Profesional
    {
        public int ID_Profesional { get; set; } // <-- DEBE EXISTIR Y SER INT
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int ID_Especialidad { get; set; }
        public string NombreCompleto => $"{Apellido}, {Nombre}"; // <-- O esta o solo Nombre/Apellido
    }
}