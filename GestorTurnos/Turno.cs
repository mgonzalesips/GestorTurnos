using System;

namespace GestorTurnos
{
    public class Turno
    {
        public TurnoTipo TurnoTipo { get; }
        public Persona Paciente { get; }

        public Turno(TurnoTipo turnoTipo, Persona paciente)
        {
            TurnoTipo = turnoTipo;
            Paciente = paciente;
        }

        public decimal CalcularPrecioTurno()
        {
            return TurnoTipo.Precio;
        }

        public void Guardar()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[BASE DE DATOS] Conectando a la base de datos...");
            Console.WriteLine($"[BASE DE DATOS] Insertando turno: Paciente={Paciente.Nombre}, DNI={Paciente.Dni}, Tipo={TurnoTipo.NombreTipo}, Precio=${CalcularPrecioTurno()}");
            Console.WriteLine("[BASE DE DATOS] Turno guardado correctamente.");
            Console.WriteLine("----------------------------------------------------");
        }

        public void MostrarComprobante()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("           COMPROBANTE DE TURNO - CLÍNICA           ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Paciente:   {Paciente.Nombre}");
            Console.WriteLine($"DNI:        {Paciente.Dni}");
            Console.WriteLine($"Email:      {Paciente.Email}");
            Console.WriteLine($"Tipo turno: {TurnoTipo.NombreTipo}");
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
