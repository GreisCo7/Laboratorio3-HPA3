using System;

namespace CasoJuegoCraps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de Craps!\n");

            // Crea un objeto de la clase Craps
            Craps juego = new Craps();

            // Llama al método Jugar para iniciar el juego
            juego.Jugar();
        }
    }
}
