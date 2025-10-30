using Consultorio.AccesoDatos;
using Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.LogicaNegocio
{
    public class HistoriaClinicaBLL
    {
        private HistoriaClinicaDAL hcDAL = new HistoriaClinicaDAL();

        public HistoriaClinica ObtenerOHCrearPorPacienteID(int idPaciente)
        {
            // Busca la HC
            HistoriaClinica hc = hcDAL.ObtenerPorPacienteID(idPaciente);

            if (hc == null)
            {
                // Si no existe, la crea
                int nuevoId = hcDAL.Crear(idPaciente);
                // Y la vuelve a buscar para devolver el objeto completo
                hc = hcDAL.ObtenerPorPacienteID(idPaciente);
            }
            return hc;
        }
    }
}
