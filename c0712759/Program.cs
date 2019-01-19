using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0712759
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation _Mary = new StudentInformation("Mary", 3.8, 20);
            StudentInformation _John = new StudentInformation("John", 2.0, 10);
            StudentInformation _Mark = new StudentInformation("Mark ", 0.2, 3);
            StudentInformation _Steve = new StudentInformation("Steve", 2.9, 16);
            StudentInformation _cindy = new StudentInformation("cindy", 3.9, 187);
        }
        class StudentInformation
        {
            public string Name;
        
            public double GPA;
            public int Attendence;
            public StudentInformation(string aName, double cGPA, int dAttendence)
            {
                Name = aName;
                GPA = cGPA;
                Attendence = dAttendence;



            }
        }
    }
}