using Consultorio.AccesoDatos;
using Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.LogicaNegocio
{
    public class AtencionBLL
    {
        private AtencionDAL atencionDAL = new AtencionDAL();

        public int Registrar(Atencion atencion)
        {
            // Aquí irían validaciones, ej. que el diagnóstico no esté vacío
            return atencionDAL.Registrar(atencion);
        }

        public DataTable ListarPorHistoriaID(int idHistoria)
        {
            return atencionDAL.ListarPorHistoriaID(idHistoria);
        }
    }
}
