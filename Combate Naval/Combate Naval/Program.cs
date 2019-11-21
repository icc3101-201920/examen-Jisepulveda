using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combate_Naval
{
    class Program
    {
        static void Main(string[] args)
        {
            string logo = "COMBATE NAVAL";

            Console.WriteLine(logo);

            while (true)
            {
                string starMenu = "\n 1- Nuevo Juego \n 2- Cargar Juego \n 3-Salir";

                Console.WriteLine(starMenu);

                Console.WriteLine("\nIngrese Opcion desada: "); string option = Console.ReadLine();

                if(option == "1")
                {
                    Game game = new Game();
                    game.newGame();

                    game.play();
                }

                if (option == "2")
                {
                    
                }

                if (option == "3")
                {
                    break;
                }
                
                else
                {
                    Console.WriteLine("---- Opcion ingresada no valida ----");
                }
            }
        }
    }
}
