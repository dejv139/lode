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
        public Board()
        {
            for (int i = 1; i <= 10; i++)
            {
                for(int u = 1; u <= 10; u++)
                {
                    board.Add(new Point
                    {
                        X = i,
                        Y = u
                    });
                    Console.Write("|_|");
                }
                Console.Write("\n");

            }
            
        }


    }
}
