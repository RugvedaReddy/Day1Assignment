using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class Person
    {
        string FName;
        string SName;
        string Email;
        DateTime DOB;

        public Person(string FName,string SName,string Email,DateTime DOB)
        {
            this.FName = FName;
            this.SName = SName;
            this.Email = Email;
            this.DOB = DOB;

        }
        public Person(string first,string last,string email)
        {
            this.FName = first;
            this.SName = last;
            this.Email = email;

        }

        public Person(string F,string L, DateTime DOB)
        {
            this.FName = F;
            this.SName = L;
            this.DOB = DOB;
        }
        public void Adult()
        {
            if(DateTime.Now.Year-this.DOB.Year>18)
            {
                Console.WriteLine("person is adult");
            }
            else
            {
                Console.WriteLine("person is not adult");
            }
        }
        public void BirthdayCheck()
        {
            if(DateTime.Now.Month==this.DOB.Month)
            {
                if(DateTime.Now.Day==this.DOB.Day)
                {
                    Console.WriteLine("happy birthday");
                }
            }
           
        }
        public void SunSign()
        {
            if (this.DOB.Month == 1)
                Console.WriteLine("sun sign is :Aries");
            else if(this.DOB.Month ==2)
                Console.WriteLine("sun sign is :tarus");
            else if(this.DOB.Month ==3)
                Console.WriteLine("sun sign is :gemini");
            else if (this.DOB.Month == 4)
                Console.WriteLine("sun sign is :cancer");
            else if (this.DOB.Month == 5)
                Console.WriteLine("sun sign is :leo");
            else if (this.DOB.Month == 6)
                Console.WriteLine("sun sign is :vigro");
            else if (this.DOB.Month == 7)
                Console.WriteLine("sun sign is :libra");
            else if (this.DOB.Month == 8)
                Console.WriteLine("sun sign is :scorpio");
            else if (this.DOB.Month == 9)
                Console.WriteLine("sun sign is :sagitlarious");
            else if (this.DOB.Month == 10)
                Console.WriteLine("sun sign is :capricorn");
            else if (this.DOB.Month == 11)
                Console.WriteLine("sun sign is :aquarius");
            else if (this.DOB.Month == 12)
                Console.WriteLine("sun sign is :piesces");

        }



    }
}
