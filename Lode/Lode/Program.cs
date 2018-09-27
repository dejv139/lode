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
            int valueDirection = 0;
            int boatType = 5;
            Board deska1 = new Board();

            while (gameCycle == true)
            {
                deska1.printBoard();
                Board deska2 = new Board();
                bool pomX = true;
                bool pomY = true;
                bool pomDir = true;

                while (pomX == true)
                {
                    Console.Write("Input X for base square: ");
                    string xPos = Console.ReadLine();

                    if (int.TryParse(xPos, out valueX))
                    {
                        valueX = Convert.ToInt32(xPos);
                        if (( 0 < valueX) && (valueX <= deska1.Hor))
                        {
                            pomX = false;
                        }
                        else
                        {
                            Console.WriteLine("It won't fit ;)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input must be numeric");
                    }
                }

                while (pomY == true)
                {
                    Console.Write("Input Y for base square: ");
                    string yPos = Console.ReadLine();

                    if (int.TryParse(yPos, out valueY))
                    {
                        valueY = Convert.ToInt32(yPos);
                        if ((0 < valueX) && (valueY <= deska1.Ver))
                        {
                            pomY = false;
                        }
                        else
                        {
                            Console.WriteLine("It won't fit ;)");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Input must be numeric");
                    }
                }

                while (pomDir == true)
                {
                    if(boatType == 1)
                    {
                        pomDir = false;
                    } else if ((boatType == 3)||(boatType == 5))
                    {
                        Console.Write("Input direction (0- Vertical, 1- Down): ");
                        string direction = Console.ReadLine();

                        if (int.TryParse(direction, out valueDirection))
                        {
                            valueDirection = Convert.ToInt32(direction);
                            if (Enumerable.Range(0, 2).Contains(valueDirection))
                            {
                                pomDir = false;
                            }
                            else
                            {
                                Console.WriteLine("Input must be within range");
                            }
                        }
                    }
                    else
                    {
                        Console.Write("Input direction (0- Up, 1- Right, 2- Down, 3- Left): ");
                        string direction = Console.ReadLine();

                        if (int.TryParse(direction, out valueDirection))
                        {
                            valueDirection = Convert.ToInt32(direction);
                            if (Enumerable.Range(0, 4).Contains(valueDirection))
                            {
                                pomDir = false;
                            }
                            else
                            {
                                Console.WriteLine("Input must be within range");
                            }
                        }
                    }
                    
                }

                Lod boat = new Lod(valueX, valueY, valueDirection, boatType);
                List<Point> lod = boat.markBoat(deska2);
                Console.Clear();
                deska2.updateBoard(lod);
                deska2.printBoard();
                Console.WriteLine("Spoko?");
                Console.Write("y/n: ");
                string choice = Console.ReadLine();

                if ((choice == "y") || (choice == "Y"))
                {
                    List<Point> lodPlacement = boat.markBoat(deska1);
                    deska1.updateBoard(lodPlacement);
                    Console.Clear();
                }

            }

        }
    }
}
