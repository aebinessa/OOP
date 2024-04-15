using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public double Gpa { get; set; }

        public Student(string name, string major, double GPA)
        {
            Name = name;
            Major = major;
            Gpa = GPA;
        }

        public virtual void StudentSummary()
        {
            Console.WriteLine($"{Name}, {Major}, {Gpa}");
        }



    }
}
