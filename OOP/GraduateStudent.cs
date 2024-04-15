using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
      public class GraduateStudent : Student
    {
        public string AdvisorName { get; set; }

        public GraduateStudent(string name, string major, double gpa, string advisorName)
            : base(name, major, gpa)
        {
            AdvisorName  = advisorName; 
        }

        public override void StudentSummary()
        {
            base.StudentSummary();
            Console.WriteLine($"advisor: {AdvisorName}");
        }
    }

}
