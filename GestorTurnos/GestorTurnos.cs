using System;

namespace GestorTurnos
{
    // Principio de inversión de dependencias (DIP): GestorTurnos (alto nivel) depende
    // de la abstracción INotificadorTurno, no de sus implementaciones concretas.
    // Quien lo construye decide qué implementación usar.
    public class GestorTurnos
    {
        private readonly INotificadorTurno notificador;

        public GestorTurnos(INotificadorTurno notificador)
        {
            this.notificador = notificador;
        }
        //sobrecargar de operadores en el constructor para permitir el uso de diferentes notificaciones
        public GestorTurnos()
            : this(new NotificadorMultiple(new NotificadorEmailTurno(), new NotificadorSMS()))
        {
        }

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

                case "Urgente":
                    turnoTipo = new TurnoUrgente();
                    break;

                case "Seguimiento":
                    turnoTipo = new TurnoSeguimiento();
                    break;

                default:
                    Console.WriteLine("Error: Tipo de turno no valido.");
                    return;
            }

            Turno turno = new Turno(turnoTipo, paciente);
            notificador.Notificar(turno);
            turno.MostrarComprobante();
        }
    }
}
