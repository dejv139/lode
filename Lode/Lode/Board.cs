using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode
{
    class Board
    {
        private List<Point> board = new List<Point>();
        public int Ver = 10;
        public int Hor = 10;

        public Board()
        {
            for (int i = 1; i <= Hor; i++)
            {
                for(int u = 1; u <= Ver; u++)
                {
                    board.Add(new Point
                    {
                        X = i,
                        Y = u
                    });
                }
            }
            
        }

        public List<Point> vypisBoard()
        {
            return board;
        }

        public void updateBoard(List<Point> updatedBoard)
        {
            board = updatedBoard;
        }

        public void printBoard() {
			Console.Write("\n");
			for (int p = 1; p < Ver*Hor+1; p++)
			{
				if (board[p-1].Occ == 1)
				{
					Console.BackgroundColor = ConsoleColor.DarkGreen;
				}

				Console.Write("|__|");
				Console.ResetColor();
				Console.Write("");

				if (p % Ver == 0)
				{
					Console.Write("\n\n");
				}
			}
		}


    }
}
