using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode
{
    class Status
    {
        public bool Occupied { get; set; } = false;
        public bool Free { get; set; } = true;
        public bool Destroyed { get; set; } = false;
        public bool Missed { get; set; } = false;
    }
}
