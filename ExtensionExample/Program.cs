using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace ExtensionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator C = new Calculator();
            Console.WriteLine(C.Add(12, 13));
            Console.WriteLine(C.Sub(12, 12));
            Console.WriteLine(C.Mul(12, 13));
        }
    }
}
