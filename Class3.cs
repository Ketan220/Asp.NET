/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public double salary { get; set; }

    }

    internal class Class3
    {
        public delegate double empdelegate(employee emp);
        static void Main(string[] args)
        {
            //creating an object of employee class
            employee e = new employee() { salary = 25000 };
            //creating a lamda expression
            empdelegate ed = s => s.salary;
            //calling 
            double res = ed(e);
            Console.WriteLine("emp salary is " + res);
            Console.ReadKey();

        }

    }
}*/