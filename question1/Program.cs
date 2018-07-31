using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            char transtype;
            int amount;

            Console.WriteLine("enter acc no.");
            int ANo = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter acc type");
            string AType =Console.ReadLine();
            Account obj = new Account(ANo, name, AType);
            Console.WriteLine("ENTER TRANSACTION TYPE(d/w)");
            transtype = char.Parse(Console.ReadLine());
            Console.WriteLine("enter amount");
            amount = int.Parse(Console.ReadLine());
            if (transtype == 'd')
                obj.credit(amount);
            else if (transtype == 'w')
                obj.debit(amount);
            obj.ShowData();







        }
    }
}
