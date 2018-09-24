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
        private List<Point> immune = new List<Point>();
        private bool direction = true; // true = horizontální, false = vertikální
        private int width = 3;
        private int height = 1;

        public Lod(int x, int y)
        {
            squares.Add(new Point
            { 
                    X = x,
                    Y = y
            });
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
                        bSquare.Occ = 1;
                        bSquare.occBy = this;
                        immune.Add(bSquare);
                    }
                    else
                    {
                        if (bSquare.occBy == this && immune.Contains(bSquare) == false)
                        {
                            bSquare.Occ = 0;
                            bSquare.occBy = null;
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
            }
        }


        public void changeDirection()
        {
            if (direction == true)
            {
                direction = false;
            }
            else
            {
                direction = true;
            }
        }

        public string getDirection()
        {
            if (direction == true)
            {
                return "horizontal";
            }
            else
            {
                return "vertical";
            }
        }
    }
}

