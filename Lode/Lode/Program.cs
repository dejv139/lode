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
            Lod boat = new Lod();
            Board deska = new Board();
            List<Point> lod = boat.markBoat(deska);
            deska.updateBoard(lod);
            deska.printBoard();


            string pozice = boat.getDirection();
            Console.WriteLine(pozice);
        }
    }
}
