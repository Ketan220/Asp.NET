/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class batch
    {
        public int batchid { get; set; }
        public string course { get; set; }
        public string faculty { get; set; }
        public int fees { get; set; }
    }

    internal class Class8
    {
        delegate int batchdelegate(batch b);
        static void Main(string[] args)
        {
            batchdelegate bd = d =>
            {
                Console.WriteLine("batch is " + d.batchid);
                Console.WriteLine("course  " + d.course);
                Console.WriteLine("faculty is " + d.faculty);
                d.fees = 60000;
                return d.fees;
            };

            Console.WriteLine("enter batch details");
            int bid = Convert.ToInt32(Console.ReadLine());
            string co = Console.ReadLine();
            string fa = Console.ReadLine();

            batch ba = new batch() { batchid = bid, course = co, faculty = fa };
            int res = bd(ba);
            Console.WriteLine("fees : " + res);
            Console.ReadKey();

        }
    }
}*/