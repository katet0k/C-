using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class StudentGrades
    {
        public string StudentName { get; set; }
        public double[] Grades { get; set; }

        public double MaxGrade => Grades.Max();
        public double AverageGrade => Grades.Average();
    }

}
