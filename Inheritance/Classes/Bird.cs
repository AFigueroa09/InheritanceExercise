using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    internal class Bird : Animal
    {
        public Bird() {
            LegCount = 2;
            Diet = "Seeds, bugs, nectar";
            ColdBlooded = false;
        }

        public string Song {  get; set; }
        public double EggWeight { get; set; }
        public int WeekOfFirstFlight { get; set; }
        public int FeatherLength { get; set; }
    }
}
