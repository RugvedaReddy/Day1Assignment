using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    class Account
    {
        int AccNo;
        string CustName;
        string AccType;
        double Balance;
      

        public Account(int ANo,string Name,string AType)
        {
            AccNo = ANo;
            CustName = Name;
            AccType = AType;
        }
        public void credit(int amount)
        {
            Balance = Balance + amount;
           
        }
        public void debit(int amount)
        {
            Balance = Balance - amount;
        }
        public void ShowData()
        {
            Console.WriteLine("account number :" + AccNo);
            Console.WriteLine("CUSTOMER NAME: " + CustName);
            Console.WriteLine("account type :" + AccType);
            Console.WriteLine("balance :" + Balance);
        }

    }
}
