using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_14_1
{
    internal class CalculatorPlugin : IPlugin
    {
        private int a;
        private int b;
        public CalculatorPlugin(int a, int b) 
        {
            this.a = a;
            this.b = b;
        }
        public void Execute() 
        {
            Console.WriteLine(a + b);
        }
    }
}
