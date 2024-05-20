using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_12
{
    public class bike : vehicle
    {
        private string type;
        public bike(string name, int maxspeed, string type) : base(name, maxspeed)
        {
            this.type = type;
            Console.WriteLine($"Name of bike: {name}\nMax speed: {maxspeed}\nType of bike: {type}");
        }
        public override void Move() { Console.WriteLine("The bike is moving"); }
    }
}
