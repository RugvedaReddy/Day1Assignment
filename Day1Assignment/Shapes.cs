using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    class Shapes
    {
        [MethodInfo(MethodName ="AREA", ReturnType ="DOUBLE", Parameters = "length and breadth", Message = "USED TO CALCULATE AREA OF RECTANGLE")]
        public double Area(double L,double B)
            {
            double area = L * B;
            
                return area;
            }
        [MethodInfo(MethodName = "AREA", ReturnType = "DOUBLE", Parameters = "RADIUS", Message = "USED TO CALCULATE AREA OF CIRCLE")]

        public double Area(double radius)
        {
            double CircleArea = 3.14 * radius * radius;
            return CircleArea;
        }
        [MethodInfo(MethodName = "AREA", ReturnType = "DOUBLE", Parameters = "SIDE", Message = "USED TO CALCULATE AREA OF SQUARE")]

        public double Area(float side)
        {
            double SquareArea = side * side;
            return SquareArea;
        }
        [MethodInfo(MethodName = "AREA", ReturnType = "DOUBLE", Parameters = "BASE AND HEIGHT", Message = "USED TO CALCULATE AREA OF TRIANGLE")]
        public double Area(float B,float H)
        {
            double triarea = 0.5 * B * H;
            return triarea;
        }

        

        
    }
    
}
