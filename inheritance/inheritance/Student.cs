using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Student : Person
    {
        public string course;
        public int marks;


        public void ShowData()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(course);
            Console.WriteLine(marks);
        }
    }
}
