using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_12
{
    public class car : vehicle
    {
        private int doorcount;
        public car (string name, int maxspeed, int doorcount) : base(name, maxspeed) 
        {
            this.doorcount = doorcount;
            Console.WriteLine($"Name of car: {name}\nMax speed: {maxspeed}\nDoors count: {doorcount}");
        }
        public override void Move() { Console.WriteLine( "The car is moving"); }
    }
}
