using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBFinalProject
{
    public partial class frmGradesHistory : Form
    {
        StreamWriter file;
        StreamReader fileReader;
        DataTable tableArc;

        public frmGradesHistory()
        {
            InitializeComponent();
            lblFinale.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            tbGrade.Visible = false;
            tbTime.Visible = false;
            tbDeltaOne.Visible = false;
        }

        public frmGradesHistory(double[] grades, string id, int[] times)
        {
            InitializeComponent();

            // Get the total grade
            double totalGrade = 0;
            for (int i = 0; i < 8; i++)
            {
                totalGrade += grades[i];
            }

            // Get the total time
            int totalTime = 0;
            for (int i = 0; i < 8; i++)
            {
                totalTime += times[i];
            }

            tbGrade.Text = totalGrade.ToString();
            tbTime.Text = totalTime.ToString();
            tbID.Text = id;

            // Get the past grades and present them
            string[] lastTwoGrades = getHistoryByID(id, true);
            tbDeltaOne.Text = lastTwoGrades[0];

            // Build the string to save to the file
            string currentTest = id + @"!" +
                DateTime.Now.ToShortDateString() + @"!" +
                DateTime.Now.ToShortTimeString() + @"!" +
                totalGrade.ToString() + @"!" +
                totalTime.ToString() + @"!";

            for (int i = 0; i < 8; i++)
			{
                currentTest += i.ToString() + @"-" + "time:" + times[i] + "-grade:" + grades[i] + @"!";
			}

            fileReader = new System.IO.StreamReader(@"C:\לימודים\פרוייקט סיכום המחשב והמוח\CABFinal\Resources\arc.txt");
            
            string str = fileReader.ReadToEnd();
            fileReader.Close();
            File.Delete(@"C:\לימודים\פרוייקט סיכום המחשב והמוח\CABFinal\Resources\arc.txt");
            str = currentTest + Environment.NewLine + str;

            file = new StreamWriter(@"C:\לימודים\פרוייקט סיכום המחשב והמוח\CABFinal\Resources\arc.txt", true);
            file.Write(str);
            file.Close();
        }
            
        public string getID()
        {
            return tbID.Text;
        }

        /// <summary>
        /// Get all the grades and the times from the history
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="isNeedTwoGrades"></param>
        public string[] getHistoryByID(string ID, bool isNeedTwoGrades)
        {
            fileReader = new System.IO.StreamReader(@"C:\לימודים\פרוייקט סיכום המחשב והמוח\CABFinal\Resources\arc.txt");
            //int counter = 0;
            string line;
            string[] testFromPast = {"0","0","0","0","0","0","0","0","0","0","0","0","0"};
            string[] twoLastGrades = { "", "" };

            dgvArc.Rows.Clear();

            // Read the file and display it line by line.
            while ((line = fileReader.ReadLine()) != null)
            {
                if (line.StartsWith(ID))
                {
                    testFromPast = line.Split('!');

                    dgvArc.Rows.Add(testFromPast[1], testFromPast[2], testFromPast[3], testFromPast[4]);
                
                    if (isNeedTwoGrades)
                    {
                        if (twoLastGrades[0] == "")
                        {
                            // save the grade
                            twoLastGrades[0] = testFromPast[3];
                        }
                        else if (twoLastGrades[1] == "")
                        {
                            twoLastGrades[1] = testFromPast[3];
                        }
                    }
                }
            }

            fileReader.Close();

            dgvArc.Refresh();
            dgvArc.Show();

            return twoLastGrades;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getHistoryByID(tbID.Text, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ExamGrades> lstExams = new List<ExamGrades>();
            ExamGrades ex = new ExamGrades();
            ex.ID = 3030;
            ex.TotalGrade = 30;
            ex.GradesList = new double[] {3.1,4.1,4,6};
            ex.TimesCounterList = new int[] {1,3,6,2}; 
            lstExams.Add(ex);



            GradesReportForm frmReport = new GradesReportForm(lstExams);

            frmReport.ShowDialog();
        }


        private void GradesHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
