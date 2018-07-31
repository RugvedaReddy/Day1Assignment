using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    class ReadAttributeValues
    {
        public void ReadAttribute(Type t)
        {
            MethodInfo mi = (MethodInfo)Attribute.GetCustomAttribute(t, typeof(MethodInfo));
            if (mi == null)
                Console.WriteLine("No Attribute Used");
            else
            {
                Console.WriteLine(mi.MethodName + " , " + mi.ReturnType + " ," + mi.Parameters + " , " + mi.Message);
            }


        }
    }
}
