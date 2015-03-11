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
    public partial class frmWordsHour : frmBasicForm
    {
        public frmWordsHour()
        {
            InitializeComponent();
        }

        public override void CheckTestGrade()
        {
            if (tbHour.Text == "15:23")
            {
                FinalGrade++;
            }
            else if (tbHour.Text == "3:23")
            {
                FinalGrade += 0.5;
            }
        }
    }
}
