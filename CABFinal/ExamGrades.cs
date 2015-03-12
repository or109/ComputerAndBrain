using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBFinalProject
{
   public class ExamGrades
    {
        public int ID { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public int TotalGrade { get; set; }
        
        public int TotalTime { get; set; }

        public double[] GradesList { get; set; }

        public int[] TimesCounterList { get; set; }

    }
}
