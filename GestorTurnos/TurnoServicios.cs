using System;
using System.Collections.Generic;

namespace GestorTurnos
{
    public class NotificadorEmailTurno : INotificadorTurno
    {
        public void Notificar(Turno turno)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[EMAIL] Conectando al servidor SMTP...");
            Console.WriteLine($"[EMAIL] Enviando confirmación de turno a {turno.Paciente.Email}...");
            Console.WriteLine("[EMAIL] Email enviado correctamente.");
            Console.WriteLine("----------------------------------------------------");
        }
    }

    public class NotificadorSMS : INotificadorTurno
    {
        public void Notificar(Turno turno)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[SMS] Conectando a la pasarela de SMS...");
            Console.WriteLine($"[SMS] Enviando confirmación de turno al teléfono asociado a {turno.Paciente.Nombre}...");
            Console.WriteLine("[SMS] SMS enviado correctamente.");
            Console.WriteLine("----------------------------------------------------");
        }
    }

    public class NotificadorMultiple : INotificadorTurno
    {
        private readonly List<INotificadorTurno> notificadores;

        public NotificadorMultiple(params INotificadorTurno[] notificadores)
        {
            this.notificadores = new List<INotificadorTurno>(notificadores);
        }

        public void Notificar(Turno turno)
        {
            foreach (var notificador in notificadores)
            {
                notificador.Notificar(turno);
            }
        }
    }

    public class RepositorioTurnoBaseDeDatos : IRepositorioTurno
    {
        public void Guardar(Turno turno)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[BASE DE DATOS] Conectando a la base de datos...");
            Console.WriteLine($"[BASE DE DATOS] Insertando turno: Paciente={turno.Paciente.Nombre}, DNI={turno.Paciente.Dni}, Tipo={turno.TurnoTipo.NombreTipo}, Precio=${turno.CalcularPrecioTurno()}");
            Console.WriteLine("[BASE DE DATOS] Turno guardado correctamente.");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
