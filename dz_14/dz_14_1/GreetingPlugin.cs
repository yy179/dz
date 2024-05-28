using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_14_1
{
    internal class GreetingPlugin : IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("Hello!");
        }
    }
}
