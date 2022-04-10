using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class9
    {
        delegate string caldel(float total);
        static void Main(string[] args)
        {
            caldel cd = c =>
            {
                float per;
                per = (c / 500.0f) * 100.0f;
                return "percantge = " + per;
            };

            Console.WriteLine("enter total marks");
            float t = Convert.ToSingle(Console.ReadLine());
            string res = cd(t);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}