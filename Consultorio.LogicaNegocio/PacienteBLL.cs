using Consultorio.AccesoDatos;
using Consultorio.Entidades;
using System;

namespace Consultorio.LogicaNegocio
{
    public class PacienteBLL
    {
        private PacienteDAL pacienteDAL = new PacienteDAL();

        public Paciente BuscarPorDNI(string dni)
        {
            if (string.IsNullOrEmpty(dni))
            {
                throw new Exception("El DNI es obligatorio.");
            }
            return pacienteDAL.BuscarPorDNI(dni);
        }

        public Paciente Registrar(Paciente paciente)
        {
            if (string.IsNullOrEmpty(paciente.DNI) || string.IsNullOrEmpty(paciente.Nombre) || string.IsNullOrEmpty(paciente.Apellido))
            {
                throw new Exception("DNI, Nombre y Apellido son obligatorios.");
            }
            // Validar si el DNI ya existe
            if (pacienteDAL.BuscarPorDNI(paciente.DNI) != null)
            {
                throw new Exception("Ya existe un paciente con ese DNI.");
            }

            int nuevoId = pacienteDAL.Registrar(paciente);
            paciente.ID_Paciente = nuevoId;
            return paciente;
        }
    }
}
