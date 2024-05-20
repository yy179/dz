using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_12
{
    public class vehicle
    {
        private string name;
        private int maxspeed;
        public vehicle(string name, int maxspeed)
        {
            this.name = name;
            this.maxspeed = maxspeed;
        }
        public virtual void Move() { Console.WriteLine("The vehicle is moving"); }
    }
}
