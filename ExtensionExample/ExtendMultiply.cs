using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;


namespace ExtensionExample
{
    static class ExtendMultiply
    {
        public static int Mul(this Calculator C,int x,int y)
        {
            return (x * y);
        }
    }
}
