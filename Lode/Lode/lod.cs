using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode
{
    class Lod
    {
        private int locY = 5;
        private int locX = 5;
        private int lenght = 3;
        private bool direction = true; // true = horizontální, false = vertikální

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

