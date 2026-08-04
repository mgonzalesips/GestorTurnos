using System;

namespace GestorTurnos
{
    public class GestorTurnos
    {
        public void ProcesarTurno(string nombrePaciente, string dni, string tipoTurno, string email)
        {
            Persona paciente = new Persona(nombrePaciente, dni, email);

            if (Turno.ValidarPaciente(paciente) == false)
            {
                Console.WriteLine("Error: Datos del paciente inválidos. No se puede procesar el turno.");
                return;
            }

            TurnoTipo turnoTipo = new TurnoTipo(tipoTurno);
            Turno turno = new Turno(turnoTipo, paciente);
            turno.Guardar();
            turno.Notificar();
            turno.MostrarComprobante();
        }
    }
}
