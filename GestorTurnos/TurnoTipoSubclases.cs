using System;

namespace GestorTurnos
{
    public class TurnoNormal : TurnoTipo
    {
        public override string NombreTipo => "Normal";
        public override decimal Precio => 5000m;

    }

    public class TurnoUrgente : TurnoTipo
    {
        public override string NombreTipo => "Urgente";
        public override decimal Precio => 8000m;
    }

    public class TurnoSeguimiento : TurnoTipo
    {
        public override string NombreTipo => "Seguimiento";
        public override decimal Precio => 3000m;
    }
}
