using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBFinalProject
{
    public partial class frmAnalogHour : frmBasicForm
    {
        public frmAnalogHour()
        {
            InitializeComponent();
        }

        public override void CheckTestGrade()
        {
            if (tbHour.Text == "8:00")
            {
                FinalGrade++;
            }
            else if (tbHour.Text == "20:00")
            {
                FinalGrade += 0.5;
            }
        }
    }
}
