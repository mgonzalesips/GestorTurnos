using System;

namespace GestorTurnos
{
    public abstract class TurnoTipo
    {
        public virtual string NombreTipo { get; }
        public virtual decimal Precio { get; }
    }
}
