using System;
using System.Collections.Generic;
using System.Text;

namespace GestorTurnos
{
    internal class Turno
    {
        int TurnoID;
        DateTime fecha;
        string TurnoTipo;
        string nombrePaciente;
        string dniPaciente;
        string mailPaciente;

        public Turno(int turnoID, DateTime fecha, string turnoTipo, string nombrePaciente, string dniPaciente, string mailPaciente)
        {
            TurnoID = turnoID;
            this.fecha = fecha;
            TurnoTipo = turnoTipo;
            this.nombrePaciente = nombrePaciente;
            this.dniPaciente = dniPaciente;
            this.mailPaciente = mailPaciente;
        }

        public bool ValidarPaciente(string nombre, string dni, string email) 
        {
            if (string.IsNullOrWhiteSpace(nombrePaciente))
            {
                Console.WriteLine("Error: el nombre del paciente es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(dni) || dni.Length < 7)
            {
                Console.WriteLine("Error: el DNI ingresado no es válido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                Console.WriteLine("Error: el email ingresado no es válido.");
                return false;
            }

            return true;
        }

        decimal CalcularPrecioTurno()
        {
            decimal precio;
            switch (TurnoTipo)
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
                    return -1;
            }

            return precio;
        }


    }
}
