using Consultorio.AccesoDatos;
using Consultorio.Entidades;
using System.Collections.Generic;

namespace Consultorio.LogicaNegocio
{
    public class EspecialidadBLL
    {
        private EspecialidadDAL especialidadDAL = new EspecialidadDAL();

        public List<Especialidad> ListarTodas()
        {
            // Podríamos agregar reglas de negocio, ej. filtrar solo especialidades activas
            return especialidadDAL.ListarTodas();
        }
    }
}
