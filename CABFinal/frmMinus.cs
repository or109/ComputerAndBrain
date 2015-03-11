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
    public partial class frmMinus : frmBasicForm
    {
        public frmMinus()
        {
            InitializeComponent();
        }

        public override void CheckTestGrade()
        {
            if(tbOne.Text == "93")
            {
                FinalGrade++;
            }
            else if (tbOne.Text == "92" || tbOne.Text == "94")
            {
                FinalGrade += 0.5;
            }

            if (tbTwo.Text == "86")
            {
                FinalGrade++;
            }
            else if (tbTwo.Text == "85" || tbTwo.Text == "87")
            {
                FinalGrade += 0.5;
            }

            if (tbThree.Text == "79")
            {
                FinalGrade++;
            }
            else if (tbThree.Text == "80" || tbThree.Text == "78")
            {
                FinalGrade += 0.5;
            }

            if (tbFour.Text == "72")
            {
                FinalGrade++;
            }
            else if (tbFour.Text == "73" || tbFour.Text == "71")
            {
                FinalGrade += 0.5;
            }

            if (tbFive.Text == "65")
            {
                FinalGrade++;
            }
            else if (tbFive.Text == "66" || tbFive.Text == "64")
            {
                FinalGrade += 0.5;
            }
            
        }
    }
}
