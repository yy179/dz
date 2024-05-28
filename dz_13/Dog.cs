using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_13
{
    internal class Dog : Animal
    {
        public override void Move() { Console.WriteLine("Dog runs"); }
        public override void MakeSound() { Console.WriteLine("Bark"); }
    }
}
