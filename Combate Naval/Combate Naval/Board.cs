using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combate_Naval
{
    public class Board
    {
        private List<List<string>> board;


        public Board(List<List<string>> board)
        {
            this.board = board;
        }

        public List<List<string>> Boards
        {
            get
            {
                return this.board;
            }
        }


        public void showBoard()
        {
            foreach(List<string> column in this.board)
            {
                

                foreach(string rows in column)
                {
                    
                }
            }
        }

        public void addBoat(int a, int b, int orientation, int Points)
        {
            if (orientation == 1)
            {
                this.board[a][b] = "H";

                for (int i = 0; i < Points; i++)
                {
                    this.board[a + i][b] = "H";
                }

            }
            if (orientation == 2)
            {
                this.board[a][b] = "H";

                for (int i = 0; i < Points; i++)
                {
                    this.board[a + i][b+1] = "H";
                }

            }

            
        }

    }
}
