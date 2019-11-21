using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combate_Naval
{
    class Game
    {
        private List<Player> players;
        private List<Board> boardsGame;
        private List<List<Boats>> PlayersBoats;
        private int turn;


        public void newGame()
        {
            Console.WriteLine("\nIngrese el Nombre del Jugador 1 :");
            string nameplayer1 = Console.ReadLine();

            Player player1 = new Player( 1 , nameplayer1);

            Console.WriteLine("\nIngrese el Nombre del Jugador 2 :");
            string nameplayer2 = Console.ReadLine();

            Player player2 = new Player( 2 , nameplayer2);

            this.players.Add(player1);
            this.players.Add(player2);

            List<List<String>> board1 = new List<List<string>>();
            List<List<String>> board2 = new List<List<string>>();

            for (int i = 0; i < 10; i++)
            {
                List<string> filas = new List<string>();

                for (int a = 0; a < 10; a++)
                {
                    filas.Add("▄");
                }

                board1.Add(filas);
                board2.Add(filas);
            }


            Board boardplayer1 = new Board(board1);
            Board boardplayer2 = new Board(board2);

            turn = 0;
            setBoats();

            for( int i = 0; i<5 ; i++)
            {
                while (true)
                {
                    Console.WriteLine("\nPlayer 1 - Coloque sus barcos");
                }

                if 
            }

            

        }

        public int placeBoat(string position, int orientation, Boats boat , int player)
        {
            String[] positionboat = position.Split('x');

            if(orientation == 1)
            {
                if(boat.LifePoints + Convert.ToInt32(positionboat[0]) >= 11)
                {
                    Console.WriteLine("\n La embarcacion no puede ir en este sitio");

                    return 0;
                }


            }


            if (orientation == 2)
            {
                if (boat.LifePoints + Convert.ToInt32(positionboat[1]) >= 11)
                {
                    Console.WriteLine("\n La embarcacion no puede ir en este sitio");

                    return 0;
                }


            }


            this.boardsGame[player].addBoat(Convert.ToInt32(positionboat[0]), Convert.ToInt32(positionboat[1]), orientation, boat.LifePoints);

            return 1;
            

        }

        public void play()
        {

        }

        public void setBoats()
        {
            SpecialBoats portaaviones = new SpecialBoats("Portaaviones", 5, "Envia aviones a un cuadrante de 3x3 y revisa si existen barcos en esas casillas");
            SpecialBoats submarino = new SpecialBoats("Submarino", 3, "Se sumerge y no puede ser alcanzado por ataques durante un turno");
            SpecialBoats reparador = new SpecialBoats("Reparador", 2, "Repara a un barco colindante o a si mismo si lo anterior no se cumple");
            SpecialBoats radar = new SpecialBoats("Radar", 1, "Detecta barcos enemigos en un radio de 3x3 y solo dice si hay alguno, no la posicion exacta");
            NormalBoats fragata = new NormalBoats("Fragata", 4);

            PlayersBoats[0].Add(portaaviones);
            PlayersBoats[0].Add(portaaviones);
            PlayersBoats[0].Add(portaaviones);
            PlayersBoats[0].Add(portaaviones);
            PlayersBoats[0].Add(portaaviones);
            PlayersBoats[0].Add(portaaviones);
            PlayersBoats[0].Add(portaaviones);
            PlayersBoats[0].Add(portaaviones);
            PlayersBoats[0].Add(portaaviones);
            PlayersBoats[0].Add(portaaviones);

        }
    }
}
