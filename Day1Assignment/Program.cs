using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length and breadth of rectangle");
            double len, brd;
            len = double.Parse(Console.ReadLine()); 
            brd= double.Parse(Console.ReadLine());
            Shapes obj;
            obj = new Day1Assignment.Shapes();
            double area = obj.Area(len, brd);
            Console.WriteLine("area of rectangle= " + area);
            Console.WriteLine("enter radius of circle");
            double r = double.Parse(Console.ReadLine());

            double CA = obj.Area(r);
            Console.WriteLine("area of circle= " + CA);
            Console.WriteLine("enter side of square");
               float s= float.Parse(Console.ReadLine());
            double SA = obj.Area(s);
            Console.WriteLine("area of square= " + SA);
            Console.WriteLine("enter base and height of right triangle");
            float leg1 = float.Parse(Console.ReadLine());
            float leg2= float.Parse(Console.ReadLine());
            double tarea = obj.Area(leg1, leg2);
            Console.WriteLine("area of triangle= " + tarea);
            ReadAttributeValues R = new ReadAttributeValues();
            R.ReadAttribute(typeof(Shapes));


        }
    }

    
}
