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

    internal class Class4
    {
        delegate bool IsYoungerThan(Student stud, int youngerage);

        public static void Main()
        {
            IsYoungerThan isyoungethan = (s, youngerage) => s.Age < youngerage;
            Student stud = new Student() { Age = 21 };
            Console.WriteLine(isyoungethan(stud, 26));

        }
    }
}*/
