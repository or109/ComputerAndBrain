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
    public partial class ExThreeObj : frmBasicForm
    {
        public string[] WordsArray { get; set; }

        public ExThreeObj(string[] Words)
        {
            InitializeComponent();
            WordsArray = Words;
        }

        public override void CheckTestGrade()
        {
            if (tbOne.Text == WordsArray[0])
            {
                FinalGrade++;
            }
            if (tbTwo.Text == WordsArray[1])
            {
                FinalGrade++;
            }
            if (tbThree.Text == WordsArray[2])
            {
                FinalGrade++;
            }
                
        
        }
    }
}
