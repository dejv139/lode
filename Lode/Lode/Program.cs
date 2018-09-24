using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode
{
    class Program
    {
        static void Main(string[] args)
        {

            bool gameCycle = true;
            int valueX = 0;
            int valueY = 0;
            Board deska = new Board();
            deska.printBoard();
            while (gameCycle == true)
            {
                bool pomX = true;
                bool pomY = true;

                while (pomX == true)
                {
                    Console.Write("Input X: ");
                    string xPos = Console.ReadLine();

                    if (int.TryParse(xPos, out valueX))
                    {
                        valueX = Convert.ToInt32(xPos);
                        pomX = false;
                    }
                    else
                    {
                        Console.WriteLine("Input must be numeric");
                    }
                }

                while (pomY == true)
                {
                    Console.Write("Input Y: ");
                    string yPos = Console.ReadLine();

                    if (int.TryParse(yPos, out valueY))
                    {
                        valueY = Convert.ToInt32(yPos);
                        pomY = false;
                    }
                    else
                    {
                        Console.WriteLine("Input must be numeric");
                    }
                }

                Lod boat = new Lod(valueX, valueY);
                List<Point> lod = boat.markBoat(deska);
                Console.Clear();
                deska.updateBoard(lod);
                deska.printBoard();

            }

        }
    }
}
