﻿using System;
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
            int turn = 1;

            Board player1 = new Board();
            Board player2 = new Board();
            Board player3 = new Board();


            do
            {

                if (boatCount <= 1)
                { 
                    player1.printBoard();
                }
                else if (boatCount <= 2)
                {
                    player2.printBoard();
                }else if(boatCount <= 3)
                {
                   player3.printBoard();
                }else
                {
                    gameCycle = false;
                }

                if (boatCount <= 3)
                {
                    Board pomBoard = new Board();
                    bool pomTyp = true;
                    bool pomX = true;
                    bool pomY = true;
                    bool pomDir = true;
                    bool pomChoice = true;

                    while (pomTyp == true)
                    {
                        if (boatCount == 1)
                        {
                            Console.WriteLine("Press enter when player 2 is ready!");
                            Console.ReadKey();
                        }else if (boatCount == 2)
                        {
                            Console.WriteLine("Press enter when player 3 is ready!");
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
                        Console.WriteLine("8 - Parník");
                        string lodTyp = Console.ReadLine();
                        if (int.TryParse(lodTyp, out boatType))
                        {
                            boatType = Convert.ToInt32(lodTyp);
                            if ((0 < boatType) && (boatType <= 8))
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
                            if ((0 < valueX) && (valueX <= player1.Hor))
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
                        if ((boatType == 1) || (boatType == 6))
                        {
                            pomDir = false;
                        }
                        else if ((boatType == 3) || (boatType == 5) || (boatType == 7))
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
                    Console.WriteLine("Spoko?");
                    Console.Write("y/n: ");


                    while (pomChoice == true)
                    {
                        string choice = Console.ReadLine();
                        if ((choice == "y") || (choice == "Y"))
                        {
                            if (boatCount <= 1)
                            {
                                List<Point> lodPlacement = boat.markBoat(player1);
                                player1.updateBoard(lodPlacement);
                                boatCount++;
                                pomChoice = false;
                            }
                            else if (boatCount <= 2)
                            {
                                List<Point> lodPlacement = boat.markBoat(player2);
                                player2.updateBoard(lodPlacement);
                                boatCount++;
                                pomChoice = false;
                            }
                            else
                            {
                                List<Point> lodPlacement = boat.markBoat(player3);
                                player3.updateBoard(lodPlacement);
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

                

            } while (gameCycle == true);

            int valueAttackX;
            int valueAttackY;
            int valueAttackPlayer;

            string AttackX = Console.ReadLine();
            if (int.TryParse(AttackX, out valueAttackX))
            {
                valueAttackX = Convert.ToInt32(AttackX);
            }

            string AttackY = Console.ReadLine();
            if (int.TryParse(AttackY, out valueAttackY))
            {
                valueAttackY = Convert.ToInt32(AttackY);
            }

            string AttackPlayer = Console.ReadLine();
            if (int.TryParse(AttackPlayer, out valueAttackPlayer))
            {
                valueAttackPlayer = Convert.ToInt32(AttackPlayer);
            }

            player1.attackBoard(valueAttackX, valueAttackX, );
            player2.printAttackBoard();
            Console.ReadKey();
        }
    }
}
