namespace Consultorio.Entidades
{
    public class PersonalAdmin
    {
        public int ID_Personal { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public int? ID_Profesional_Asociado { get; set; } // Usamos int? (nullable)
    }
}
