using System;

namespace GestorTurnos
{
    public class TurnoTipo
    {
        private readonly string tipo;

        public string NombreTipo => tipo;

        public TurnoTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public decimal ObtenerPrecio()
        {
            switch (tipo)
            {
                case "Normal":
                    return 5000;
                case "Urgente":
                    return 7500;
                case "Seguimiento":
                    return 3000;
                default:
                    Console.WriteLine("Error: tipo de turno desconocido.");
                    return -1;
            }
        }
    }
}
