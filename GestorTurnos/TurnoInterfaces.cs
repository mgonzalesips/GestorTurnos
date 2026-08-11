namespace GestorTurnos
{
    // Principio de segregación de interfaces (ISP): interfaz chica y específica,
    // cada notificador solo depende del método que realmente usa.
    public interface INotificadorTurno
    {
        void Notificar(Turno turno);
    }

    // Principio de inversión de dependencias (DIP): abstracción de persistencia,
    // GestorTurnos depende de esta interfaz y no del detalle de "cómo" se guarda.
    public interface IRepositorioTurno
    {
        void Guardar(Turno turno);
    }
}
