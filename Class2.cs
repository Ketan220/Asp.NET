/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public class product
        {
            public int price { get; set; }
        }

        internal class Class2
        {
            delegate bool Checkprice(product p);
            delegate bool IsTeenAger(Student stud);

            public static void Main()
            {

                Checkprice cp = pr => pr.price > 10 && pr.price < 100;
                product prod = new product() { price = 110 };
                Console.WriteLine("is peice above 100" + cp(prod));
                IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;

                Student stud = new Student() { Age = 17 };

                Console.WriteLine(isTeenAger(stud));
                Console.ReadKey();

            }
        }
    }
}*/