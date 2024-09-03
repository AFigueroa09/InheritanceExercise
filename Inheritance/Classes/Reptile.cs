using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    internal class Reptile : Animal
    {
        public Reptile()
        {
            LegCount = 4;
            Diet = "bugs, fruit";
            ColdBlooded = true;
        }

        public bool IsNocturnal { get; set; }
        public double EggWeight { get; set; }
        public bool IsUnderground { get; set; }
        public bool IsPoisonous { get; set; }
    }
}
