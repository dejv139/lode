﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Lod occBy { get; set; }
        public int Occ { get; set; } = 0;

        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }
    }
}
