using System;

namespace GestorTurnos
{
    public class GestorTurnos
    {
        public void ProcesarTurno(string nombrePaciente, string dni, string tipoTurno, string email)
        {
            Persona paciente = new Persona(nombrePaciente, dni, email);
            TurnoTipo turnoTipo;

            if (Turno.ValidarPaciente(paciente) == false)
            {
                Console.WriteLine("Error: Datos del paciente inválidos. No se puede procesar el turno.");
                return;
            }

            switch (tipoTurno)
            {
                case "Normal":
                    turnoTipo = new TurnoNormal();
                    break;

                default:
                    Console.WriteLine("Error: Tipo de turno no valido.");
                    return;
            }

            Turno turno = new Turno(turnoTipo, paciente);
            turno.Guardar();
            turno.Notificar();
            turno.MostrarComprobante();
        }
    }
}
