using Consultorio.AccesoDatos;
using Consultorio.Entidades;
using System.Collections.Generic;

namespace Consultorio.LogicaNegocio
{
    public class ProfesionalBLL
    {
        private ProfesionalDAL profesionalDAL = new ProfesionalDAL();

        public List<Profesional> ListarPorEspecialidad(int idEspecialidad)
        {
            return profesionalDAL.ListarPorEspecialidad(idEspecialidad);
        }
    }
}