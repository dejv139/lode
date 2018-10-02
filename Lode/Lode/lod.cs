using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode
{
    class Lod
    {
        private List<Point> squares = new List<Point>();
        private List<Point> boardSquares = new List<Point>();


        public Lod(int x, int y, int direction, int boatType)
        {

            switch (boatType)
            {
                case 1:
                    squares.Add(new Point
                    {
                        X = x,
                        Y = y,
                        Occ = 1
                    });
                    break;
                case 2:
                    squares.Add(new Point
                    {
                        X = x,
                        Y = y
                    });
                    if (direction == 0)
                    {
                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y
                        });
                    }
                    else if (direction == 3)
                    {
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 1
                        });
                    }
                    else if (direction == 1)
                    {
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 1
                        });
                    }
                    else if (direction == 2)
                    {
                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y
                        });
                    }
                    break;
                case 3:
                    squares.Add(new Point
                    {
                        X = x,
                        Y = y
                    });
                    if (direction == 0)
                    {
                        squares.Add(new Point
                        {
                            X = x+1,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x-1,
                            Y = y
                        });
                    }
                    else
                    {
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 1
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 1
                        });
                    }
                    break;
                case 4:
                    squares.Add(new Point
                    {
                        X = x,
                        Y = y
                    });
                    if (direction == 0)
                    {
                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x - 2,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y
                        });
                    }
                    else if (direction == 1)
                    {
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 1
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 2
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 1
                        });
                    }
                    else if (direction == 2)
                    {
                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x + 2,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y
                        });
                    }
                    else if (direction == 3)
                    {
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 1
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 2
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 1
                        });
                    }
                    break;
                case 5:
                    squares.Add(new Point
                    {
                        X = x,
                        Y = y
                    });
                    if (direction == 0)
                    {
                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x + 2,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x - 2,
                            Y = y
                        });
                    }
                    else
                    {
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 1
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 2
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 1
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 2
                        });
                    }
                    break;
                case 6:
                    {
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 1
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 1
                        });

                        break;
                    }
                case 7:
                    {
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y
                        });
                        if(direction == 0)
                        {
                            squares.Add(new Point
                            {
                                X = x,
                                Y = y + 1
                            });
                            squares.Add(new Point
                            {
                                X = x,
                                Y = y - 1
                            });

                            squares.Add(new Point
                            {
                                X = x + 1,
                                Y = y + 1
                            });
                            squares.Add(new Point
                            {
                                X = x - 1,
                                Y = y + 1
                            });
                            squares.Add(new Point
                            {
                                X = x + 1,
                                Y = y - 1
                            });
                            squares.Add(new Point
                            {
                                X = x - 1,
                                Y = y - 1
                            });
                        }
                        else
                        {
                            squares.Add(new Point
                            {
                                X = x + 1,
                                Y = y
                            });
                            squares.Add(new Point
                            {
                                X = x - 1,
                                Y = y
                            });

                            squares.Add(new Point
                            {
                                X = x + 1,
                                Y = y + 1
                            });
                            squares.Add(new Point
                            {
                                X = x - 1,
                                Y = y + 1
                            });
                            squares.Add(new Point
                            {
                                X = x + 1,
                                Y = y - 1
                            });
                            squares.Add(new Point
                            {
                                X = x - 1,
                                Y = y - 1
                            });
                        }
                       
                        break;
                    }
                case 8:
                    squares.Add(new Point
                    {
                        X = x,
                        Y = y
                    });
                    if(direction == 0 || direction == 2)
                    {
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 1
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y + 2
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 1
                        });
                        squares.Add(new Point
                        {
                            X = x,
                            Y = y - 2
                        });

                    }else if(direction == 1 || direction == 3)
                    {
                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y 
                        });
                        squares.Add(new Point
                        {
                            X = x + 2,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y
                        });
                        squares.Add(new Point
                        {
                            X = x - 2,
                            Y = y
                        });
                    }
                    if (direction == 0)
                    {
                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y + 1
                        });

                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y - 1
                        });
                    }else if(direction == 1)
                    {
                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y + 1
                        });
                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y + 1
                        });
                    }else if (direction == 2) {
                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y + 1
                        });

                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y - 1
                        });

                    }
                    else
                    {
                        squares.Add(new Point
                        {
                            X = x - 1,
                            Y = y - 1
                        });
                        squares.Add(new Point
                        {
                            X = x + 1,
                            Y = y - 1
                        });
                    }
                    break;


            }
        }

        public List<Point> markBoat(Board gameBoard)
        {
            List<Point> boardSquares = gameBoard.vypisBoard();

            foreach (var square in squares)
            {
                foreach (var bSquare in boardSquares)
                {

                        if (square.getX() == bSquare.getX() && square.getY() == bSquare.getY())
                        {
                            if (bSquare.Occ != 1)
                            {
                                bSquare.Occ = 1;
                                bSquare.occBy = this;
                            }
                            else
                            {
                                return boardSquares;
                            }
                        }
                }
            }
            return boardSquares;
        }


        public void getPos()
        {
            foreach(var square in squares)
            {
                Console.WriteLine("X:" + square.X + "\n");
                Console.WriteLine("Y:" + square.Y + "\n");
                Console.WriteLine("Occupied:" + square.Occ + "\n");
            }
        }
    }
}