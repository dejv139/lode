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
            int boatType = 0;
            int boatCount = 0;

            Board player1 = new Board();
            Board player2 = new Board();


            while (gameCycle == true)
            {
                
                if (boatCount <= 5)
                {
                    player1.printBoard();
                }
                else
                {
                    player2.printBoard();
                }

                Board pomBoard = new Board();
                bool pomTyp = true;
                bool pomX = true;
                bool pomY = true;    
                bool pomDir = true;
                bool pomChoice = true;

                while (pomTyp == true)
                {
                    if(boatCount == 6)
                    {
                        Console.WriteLine("Press enter when player 2 is ready!");
                        Console.ReadKey();
                    }

                    Console.WriteLine("Choose a boat type:");
                    Console.WriteLine("1 - Ponorka");
                    Console.WriteLine("2 - Torpédoborec");
                    Console.WriteLine("3 - Křižník");
                    Console.WriteLine("4 - Bitevní loď");
                    Console.WriteLine("5 - letadlová loď");
                    Console.WriteLine("6 - těžký křižník");
                    Console.WriteLine("7 - katamaran");
                    string lodTyp = Console.ReadLine();
                    if (int.TryParse(lodTyp, out boatType))
                    {
                        boatType = Convert.ToInt32(lodTyp);
                        if ((0 < boatType) && (boatType <= 7))
                        {
                            pomTyp = false;
                        }
                        else
                        {
                            Console.WriteLine("Choose a type");
                        }
                    }

                }

                while (pomX == true)
                {
                    Console.Write("Input X for base square: ");
                    string xPos = Console.ReadLine();

                    if (int.TryParse(xPos, out valueX))
                    {
                        valueX = Convert.ToInt32(xPos);
                        if (( 0 < valueX) && (valueX <= player1.Hor))
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
                        if ((0 < valueX) && (valueY <= player1.Ver))
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
                    if((boatType == 1)||(boatType==6))
                    {
                        pomDir = false;
                    } else if ((boatType == 3)||(boatType == 5)||(boatType == 7))
                    {
                        Console.Write("Input direction (0- Vertical, 1- Horizontal): ");
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
                
                List<Point> lod = boat.markBoat(pomBoard);
                Console.Clear();
                pomBoard.updateBoard(lod);
                pomBoard.printBoard();
                boat.getPos();
                Console.WriteLine("Spoko?");
                Console.Write("y/n: ");
                

                while (pomChoice == true)
                {
                    string choice = Console.ReadLine();
                    if ((choice == "y") || (choice == "Y"))
                    {
                        if (boatCount <= 5)
                        {
                            List<Point> lodPlacement = boat.markBoat(player1);
                            player1.updateBoard(lodPlacement);
                            boatCount++;
                            pomChoice = false;
                        }
                        else
                        {
                            List<Point> lodPlacement = boat.markBoat(player2);
                            player2.updateBoard(lodPlacement);
                            boatCount++;
                            pomChoice = false;
                        }

                        Console.Clear();
                    }
                    else if (choice == "n" || choice == "N")
                    {
                        pomChoice = false;
                    }
                    else
                    {
                        Console.WriteLine("Input must be y or n");
                    }
                }
            }
        }
    }
}
