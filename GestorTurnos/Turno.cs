using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GestorTurnos
{
    public class Turno
    {
        int TurnoID;
        TurnoTipo turnoTipo;
        Persona paciente;

        public Turno(TurnoTipo turnoTipo, Persona paciente)
        {
            this.turnoTipo = turnoTipo;
            this.paciente = paciente;
        }

        decimal CalcularPrecioTurno()
        {
            return turnoTipo.ObtenerPrecio();
        }

        public void Guardar()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[BASE DE DATOS] Conectando a la base de datos...");
            Console.WriteLine($"[BASE DE DATOS] Insertando turno: Paciente={paciente.Nombre}, DNI={paciente.Dni}, Tipo={turnoTipo.NombreTipo}, Precio=${CalcularPrecioTurno()}");
            Console.WriteLine("[BASE DE DATOS] Turno guardado correctamente.");
            Console.WriteLine("----------------------------------------------------");
        }

        public void Notificar()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[EMAIL] Conectando al servidor SMTP...");
            Console.WriteLine($"[EMAIL] Enviando confirmación de turno a {paciente.Email}...");
            Console.WriteLine("[EMAIL] Email enviado correctamente.");
            Console.WriteLine("----------------------------------------------------");
        }

        public void MostrarComprobante()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("           COMPROBANTE DE TURNO - CLÍNICA           ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Paciente:   {paciente.Nombre}");
            Console.WriteLine($"DNI:        {paciente.Dni}");
            Console.WriteLine($"Email:      {paciente.Email}");
            Console.WriteLine($"Tipo turno: {turnoTipo.NombreTipo}");
            Console.WriteLine($"Precio:     ${CalcularPrecioTurno()}");
            Console.WriteLine("----------------------------------------------------");
        }

        public static bool ValidarPaciente(Persona paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Nombre))
            {
                Console.WriteLine("Error: el nombre del paciente es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(paciente.Dni) || paciente.Dni.Length < 7)
            {
                Console.WriteLine("Error: el DNI ingresado no es válido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(paciente.Email) || !paciente.Email.Contains("@"))
            {
                Console.WriteLine("Error: el email ingresado no es válido.");
                return false;
            }

            return true;
        }
    }
}
