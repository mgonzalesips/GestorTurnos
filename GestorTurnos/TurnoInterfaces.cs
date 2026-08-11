namespace GestorTurnos
{
    // Principio de segregación de interfaces (ISP): interfaz chica y específica,
    // cada notificador solo depende del método que realmente usa.
    public interface INotificadorTurno
    {
        void Notificar(Turno turno);
    }
}
