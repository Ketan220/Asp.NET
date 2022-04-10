/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public double salary { get; set; }


    }
    internal class Class5
    {
        public delegate bool empdelegate(employee emp, double sal);
        public static void Main()
        {
            employee e = new employee() { salary = 25000 };
            empdelegate ed = (s, sal) => s.salary < sal;

            Console.WriteLine("Enter salary");
            int sl=Convert.ToInt32(Console.ReadLine());
            bool res = ed(e, sl);
            if(res==true)
            {
                Console.WriteLine("emp slary is less");
            }
            else
            {
                Console.WriteLine("emp slary is high");
            }

        }
    }
}*/
