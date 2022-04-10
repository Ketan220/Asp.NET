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
    }

    internal class Class1
    {
        delegate bool ISTeenAger(Student stud);

        public static void Main()
        {
            ISTeenAger isteenager = delegate (Student s)
            {
                 Console.WriteLine("id = " + s.Id);
                 Console.WriteLine("Name  = " + s.Name);
                 Console.WriteLine("age = " + s.Age);
                 return s.Age > 12 && s.Age < 20;

            };
            //creating an object of student class
            Student stud = new Student() { Id = 123, Name = "ravi", Age = 18 };

            //calling the anonymouse function or method
            bool res = isteenager(stud);
            Console.WriteLine(" is teenager : " + res);
            Console.ReadKey();

        }

    }
}*/