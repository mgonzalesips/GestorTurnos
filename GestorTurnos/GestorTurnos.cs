using System;

namespace GestorTurnos
{
    public class GestorTurnos
    {
        public void ProcesarTurno(string nombrePaciente, string dni, string tipoTurno, string email)
        {
            if (string.IsNullOrWhiteSpace(nombrePaciente))
            {
                Console.WriteLine("Error: el nombre del paciente es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(dni) || dni.Length < 7)
            {
                Console.WriteLine("Error: el DNI ingresado no es válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                Console.WriteLine("Error: el email ingresado no es válido.");
                return;
            }


            decimal precio;
            switch (tipoTurno)
            {
                case "Normal":
                    precio = 5000;
                    break;
                case "Urgente":
                    precio = 7500;
                    break;
                case "Seguimiento":
                    precio = 3000;
                    break;
                default:
                    Console.WriteLine("Error: tipo de turno desconocido.");
                    return;
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[BASE DE DATOS] Conectando a la base de datos...");
            Console.WriteLine($"[BASE DE DATOS] Insertando turno: Paciente={nombrePaciente}, DNI={dni}, Tipo={tipoTurno}, Precio=${precio}");
            Console.WriteLine("[BASE DE DATOS] Turno guardado correctamente.");

            Console.WriteLine("[EMAIL] Conectando al servidor SMTP...");
            Console.WriteLine($"[EMAIL] Enviando confirmación de turno a {email}...");
            Console.WriteLine("[EMAIL] Email enviado correctamente.");

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("           COMPROBANTE DE TURNO - CLÍNICA           ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Paciente:   {nombrePaciente}");
            Console.WriteLine($"DNI:        {dni}");
            Console.WriteLine($"Email:      {email}");
            Console.WriteLine($"Tipo turno: {tipoTurno}");
            Console.WriteLine($"Precio:     ${precio}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }
    }
}
