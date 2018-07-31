using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, -1, 4, 5, 7, 9, -2, 3, 2, 10 };
            foreach (var a in arr.Where(n => n > 5))
                Console.WriteLine(a);
            string[] cities = { "Mumbai", "Chennai", "Pune", "Hyderabad", "Kolkatta","Pondicherry", "Newd Delhi" };
            foreach(var c in cities.Where(g=>g.StartsWith("P")||g.StartsWith("p")))
            {
                Console.WriteLine(c);
            }
            foreach(var c in cities.Where(x=>x.Contains("e")))
            {
                Console.WriteLine(c);
                
            }
            var result = cities.Where(x => x.Contains("e"));
            Console.WriteLine(result.Count());
            //3.5 collection initialiser adding to coll without using add
            List<Employee> emp = new List<Employee>
            {
                new Employee {Empid=100,Name="Martin",Dept="IT",Salary=35000 },
                new Employee {Empid=200,Name="Blake",Dept="HR",Salary=25000 },
                 new Employee {Empid=300,Name="Clark",Dept="Accounts",Salary=20000 },
                new Employee {Empid=400,Name="King",Dept="IT",Salary=75000 }

            };
            //display all values
            foreach (var r in emp)
                Console.WriteLine(r.Empid + " " + r.Name + " " + r.Dept + " " + r.Salary);
            Console.WriteLine("****************");
            var data = emp.Where(x => x.Empid == 100).SingleOrDefault();
            if (data == null)
                Console.WriteLine("INVALID EMPID");
            else
                Console.WriteLine(data.Empid + " " + data.Name + " " + data.Dept + " " + data.Salary);

            var data1 = emp.Where(x => x.Dept == "IT");
            if (data1.Count()== 0)
                Console.WriteLine("invalid deptname");
            else
            {
                foreach(var d in data1)
                {
                    Console.WriteLine(d.Empid + " " + d.Name + " " + d.Dept + " " + d.Salary);
                }
            }
            Console.WriteLine("******");
            var data3 = emp.Where(x => x.Dept == "IT" && x.Salary > 50000);
            foreach(var d in data3)
            {
                Console.WriteLine(d.Empid + " " + d.Name + " " + d.Dept + " " + d.Salary);
            }
            Console.WriteLine("******");

            var data4 = emp.OrderBy(x => x.Name).Select(y => y.Name);
            foreach (var d in data4)
                Console.WriteLine(d);
                Console.WriteLine("*********");
            var data5 = emp.Select(x => new { Empname = x.Name, Empsalary = x.Salary });
            foreach (var d in data5)
                Console.Write(d.Empname + " " + d.Empsalary);
            Console.WriteLine("*********");
            //summary - count of emloyee dept wise,sum of salary paid dept wise
            // key- col on which group by is given
            var grp = emp.GroupBy(x => x.Dept).Select(x => new { DeptName = x.Key, EmpCount = x.Count(), SumSalary = x.Sum(y => y.Salary) });
            foreach (var g in grp)
                Console.WriteLine(g.DeptName + " " + g.EmpCount + " "+ g.SumSalary);
            Console.WriteLine("*********");
            Console.WriteLine("max salary:" + emp.Max(x => x.Salary));
            Console.WriteLine("min salary:" + emp.Min(x => x.Salary));
            var maxsal = emp.Where(x => x.Salary == emp.Max(y => y.Salary));
            foreach (var d in maxsal)
                Console.WriteLine(d.Empid + " " + d.Name + " " + d.Dept + " " + d.Salary);
            Console.WriteLine("*********");

        }
    }
}
