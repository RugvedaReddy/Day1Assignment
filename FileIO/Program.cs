using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite rw = new ReadWrite();
            rw.WriteFile(@"C:\files\Test.txt");
            rw.ReadFile(@"C:\files\Test.txt");
        }
    }
}
