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
            Lod boat1 = new Lod();
            Board deska = new Board();

            boat1.changeDirection();
            string pozice = boat1.getDirection();
            Console.WriteLine(pozice);
        }
    }
}
