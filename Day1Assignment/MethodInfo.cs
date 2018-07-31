using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Property, AllowMultiple = true)]
    class MethodInfo:Attribute
    {
        public string MethodName { get; set; }
        public string ReturnType { get; set; }
        public string Parameters { get; set; }
        public string Message { get; set; }
    }
}
