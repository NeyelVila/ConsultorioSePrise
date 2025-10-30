using Consultorio.AccesoDatos;
using Consultorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; // Usaremos LINQ

namespace Consultorio.LogicaNegocio
{
    public class TurnoBLL
    {
        private TurnoDAL turnoDAL = new TurnoDAL();

        public List<Turno> ListarPorFechaYProfesional(DateTime fecha, int idProfesional)
        {
            return turnoDAL.ListarPorFechaYProfesional(fecha, idProfesional);
        }

        public Turno RegistrarTurno(Turno turno)
        {
            if (turno.ID_Paciente <= 0)
                throw new Exception("Debe seleccionar un paciente.");
            if (turno.ID_Profesional <= 0)
                throw new Exception("Debe seleccionar un profesional.");

            // Regla: No permitir turnos duplicados en la misma hora
            var turnosExistentes = turnoDAL.ListarPorFechaYProfesional(turno.Fecha, turno.ID_Profesional);
            if (turnosExistentes.Any(t => t.Hora == turno.Hora && !t.Es_Sobreturno))
            {
                throw new Exception("El horario seleccionado ya está ocupado.");
            }

            // Regla: Permitir solo 1 sobreturno por hora
            if (turno.Es_Sobreturno)
            {
                if (turnosExistentes.Any(t => t.Hora == turno.Hora && t.Es_Sobreturno))
                {
                    throw new Exception("Ya existe un sobreturno para ese horario.");
                }
            }

            turno.Estado = "Confirmado";
            int nuevoId = turnoDAL.Registrar(turno);
            turno.ID_Turno = nuevoId;
            return turno;
        }

        //SALA DE ESPERA Y ATENCION//
        public DataTable ListarTurnosParaAdmision(DateTime fecha)
        {
            // Solo listamos los turnos confirmados para admisión
            return turnoDAL.ListarTurnosConDatosParaAdmision(fecha, "Confirmado");
        }

        public void AcreditarPaciente(int idTurno)
        {
            // Podrías añadir validaciones adicionales aquí, por ejemplo,
            // verificar que el turno esté en estado 'Confirmado' antes de acreditar.
            turnoDAL.ActualizarEstadoTurno(idTurno, "Acreditado");
        }
        public DataTable ListarSalaDeEspera(DateTime fecha, int idProfesional)
        {
            // La sala de espera son los 'Acreditados'
            return turnoDAL.ListarTurnosPorEstadoYProfesional(fecha, idProfesional, "Acreditado");
        }

        public DataTable ObtenerPacienteEnConsulta(DateTime fecha, int idProfesional)
        {
            // Busca si el médico ya tiene a alguien en consulta
            return turnoDAL.ListarTurnosPorEstadoYProfesional(fecha, idProfesional, "En Consulta");
        }

        public void LlamarPaciente(int idTurno)
        {
            turnoDAL.ActualizarEstadoTurno(idTurno, "En Consulta");
        }

        public void FinalizarAtencion(int idTurno)
        {
            turnoDAL.ActualizarEstadoTurno(idTurno, "Atendido");
        }
    }
}
