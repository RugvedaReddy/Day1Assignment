using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            string FName;
            string LName;
            string Email;
            DateTime DOB;
            Console.WriteLine("enter first name");
                FName = Console.ReadLine();
            Console.WriteLine("enter last name");
            LName = Console.ReadLine();
            Console.WriteLine("enter email");
            Email = Console.ReadLine();
            Console.WriteLine("enter DOB");
            DOB = DateTime.Parse(Console.ReadLine());
            Person obj1 = new Person(FName, LName, Email, DOB);
            Person obj2 = new Person(FName, LName, Email);
            Person obj3 = new Person(FName, LName, DOB);
            obj1.Adult();
            obj1.BirthdayCheck();
            obj1.SunSign();
        }
    }
}
