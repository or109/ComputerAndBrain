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
    public partial class frmTimeFill : frmBasicForm
    { 

        public frmTimeFill()
        {
            InitializeComponent();
        }

        public override void CheckTestGrade()
        {
            // Check the day
            if (cbDay.Text == DateTime.Now.Day.ToString())
            {
                FinalGrade++;
            }            
            else if (cbDay.Text == (DateTime.Now.Day + 1).ToString() || cbDay.Text == (DateTime.Now.Day - 1).ToString())
            {
                FinalGrade += 0.5;
            }

            // Check the month
            if (cbMonth.Text == DateTime.Now.Month.ToString())
            {
                FinalGrade++;
            }
            else if (cbMonth.Text == (DateTime.Now.Month + 1).ToString() || cbMonth.Text == (DateTime.Now.Month - 1).ToString())
            {
                FinalGrade += 0.5;
            }

            // Check the year
            if (cbYear.Text == DateTime.Now.Year.ToString())
            {
                FinalGrade++;
            }
            else if (cbSeas.Text == (DateTime.Now.Year + 1).ToString() || cbSeas.Text == (DateTime.Now.Year - 1).ToString())
            {
                FinalGrade += 0.5;
            }

            // Check the current season
            string currSeason = string.Empty;
            if (DateTime.Now.Month  == 12 || (DateTime.Now.Month  >= 1 && DateTime.Now.Month  <= 3))
            {
                currSeason = "חורף";
            }
            else if (DateTime.Now.Month >= 4 && DateTime.Now.Month <= 6)
            {
                currSeason = "אביב";
            }
            else if (DateTime.Now.Month >= 7 && DateTime.Now.Month <= 9)
            {
                currSeason = "קיץ";
            }
            else if (DateTime.Now.Month >= 10 && DateTime.Now.Month <= 11)
            {
                currSeason = "סתיו";
            }

            // Check the season
            if (cbSeas.Text == currSeason)
            {
                FinalGrade++;
            }
        }

        private void ExTimeFill_Load(object sender, EventArgs e)
        {

        }

    }
}
