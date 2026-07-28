namespace GestorTurnos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gestor = new GestorTurnos();

            // Ejemplos de prueba: turno Normal, Urgente y Seguimiento
            gestor.ProcesarTurno("Juan Pérez", "30111222", "Normal", "juan.perez@mail.com");
            gestor.ProcesarTurno("María Gómez", "27888999", "Urgente", "maria.gomez@mail.com");
            gestor.ProcesarTurno("Carlos Ruiz", "40555666", "Seguimiento", "carlos.ruiz@mail.com");

            // Ejemplo con datos inválidos, para ver que la validación corta el proceso
            gestor.ProcesarTurno("", "123", "Normal", "email-invalido");

            // Ejemplo con tipo de turno desconocido
            gestor.ProcesarTurno("Ana López", "35777888", "Telemedicina", "ana.lopez@mail.com");

            /*
            
            Refactorizar en el siguiente orden, de S a D:

            --------------------------------------------------------------------
            S - Single Responsibility Principle (Principio de Responsabilidad Única)
            --------------------------------------------------------------------

            --------------------------------------------------------------------
            O - Open/Closed Principle (Principio de Abierto/Cerrado)
            --------------------------------------------------------------------

            --------------------------------------------------------------------
            L - Liskov Substitution Principle (Principio de Sustitución de Liskov)
            --------------------------------------------------------------------
            
            --------------------------------------------------------------------
            I - Interface Segregation Principle (Principio de Segregación de Interfaces)
            --------------------------------------------------------------------
            
            --------------------------------------------------------------------
            D - Dependency Inversion Principle (Principio de Inversión de Dependencias)
            --------------------------------------------------------------------
            */
        }
    }
}
