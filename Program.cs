using JuegoSnake.clases;
using JuegoSnake.clases.BicolaEnlazada;
using JuegoSnake.clases.Cola_Lista;
using JuegoSnake.clases.ColaArreglo;
using System;
using System.Drawing;

namespace JuegoSnake
{
    class Program
    {
        public static void menu()
        {
            int ModoJuego;
            do
            {
                Console.Clear();
                Console.WriteLine("***JUEGO CULEBRITA***\n");
                Console.WriteLine("1. Culebrita Queue");
                Console.WriteLine("2. Culebrita con BiCola");
                Console.WriteLine("3. Culebrita con ColaCircular");
                Console.WriteLine("4. Culebrita con ColaLista");
                Console.Write("Jugar: ");
                ModoJuego = Int32.Parse(Console.ReadLine());
                switch (ModoJuego)
                {
                    case 1:

                        SnakeQueue JuegoQueue = new SnakeQueue();
                        JuegoQueue.CulebraQueue();

                        break;
                    case 2:

                        SnakeConBicola JuegoCulebra = new SnakeConBicola();
                        JuegoCulebra.CulebraConBicola();

                        break;
                    case 3:

                        SnakeConColaArreglo JCcolacircular = new SnakeConColaArreglo();
                        JCcolacircular.CulebraColaCircular();

                        break;
                    case 4:

                        SnakeConColaLista JCcolaconlista = new SnakeConColaLista();
                        JCcolaconlista.CulebraConColaLista();

                        break;

                }
                

            } while (ModoJuego<=4);
            

        }
        
        static void Main(string[] args)
        {

            menu();
            
        }
    }
}
