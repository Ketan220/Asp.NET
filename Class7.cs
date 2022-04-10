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
    }

    internal class Class7
    {
        delegate void batchdelegate(batch b);
        public static void Main()
        {
            batchdelegate bd = d =>
              {
                  Console.WriteLine("Batchid=" + d.batchid);
                  Console.WriteLine("Course=" + d.course);
                  Console.WriteLine("Faculty="+d.faculty);
              };
            Console.WriteLine("Enter batch details");
            int bid=Convert.ToInt32(Console.ReadLine());                    
            string co=Console.ReadLine();
            string fo=Console.ReadLine();
            batch ba = new batch() { batchid = bid, course = co, faculty = fo };
            bd(ba);
            Console.ReadKey();
        }
    }
}*/