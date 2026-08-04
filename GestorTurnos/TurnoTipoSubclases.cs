using System;

namespace GestorTurnos
{
    public class TurnoNormal : TurnoTipo
    {
        public override string NombreTipo => "Normal";
        public override decimal Precio => 5000m;

    }
}
