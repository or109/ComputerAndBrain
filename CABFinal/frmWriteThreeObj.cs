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
        public string[] MissWordsArray { get; set; }

        public ExThreeObj(string[] Words, string[] MissWords)
        {
            InitializeComponent();
            WordsArray = Words;
            MissWordsArray = MissWords;
        }

        public override void CheckTestGrade()
        {
            bool[] b = { false, false, false };

            for (int i = 0; i < 3; i++)
            {
                if (tbOne.Text == WordsArray[i] && b[i] == false)
                {
                    FinalGrade++;
                    b[i] = true;
                }
                if (tbTwo.Text == WordsArray[i] && b[i] == false)
                {
                    FinalGrade++;
                    b[i] = true;
                }
                if (tbThree.Text == WordsArray[i] && b[i] == false)
                {
                    FinalGrade++;
                    b[i] = true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if ((tbOne.Text == MissWordsArray[i * 2] || tbOne.Text == MissWordsArray[i * 2 + 1]) && b[i] == false)
                {
                    FinalGrade += 0.5;
                    b[i] = true;
                }
                if ((tbTwo.Text == MissWordsArray[i * 2] || tbTwo.Text == MissWordsArray[i * 2 + 1]) && b[i] == false)
                {
                    FinalGrade += 0.5;
                    b[i] = true;
                }
                if ((tbThree.Text == MissWordsArray[i * 2] || tbThree.Text == MissWordsArray[i * 2 + 1]) && b[i] == false)
                {
                    FinalGrade += 0.5;
                    b[i] = true;
                }
            }
        }
    }
}
