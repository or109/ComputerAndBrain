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
    public partial class frmMain : Form
    {

        public int CurrentTest { get; set; }
        public Timer tmr_MainTimer { get; set; }

        public List<Form> TestsScreen { get; set; }

        public int[] TestTimesCounter = { 0,0,0,0,0,0,0,0 };
        public double[] SubTestGrades = { 0, 0, 0, 0, 0, 0, 0, 0 };
        
        int displayCounterStop = 0;
        public Timer tmrTemp;
        
        string idTest;
        

        public frmMain()
        {
            InitializeComponent();
            
            CurrentTest = 0;
            
            tmr_MainTimer = new Timer();
            tmr_MainTimer.Interval = 1000;

            frmGradesHistory gradeHisto = new frmGradesHistory();
            gradeHisto.TopLevel = false;
            gradeHisto.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(gradeHisto);
            gradeHisto.Visible = true;

            // Init Screens on load
            TestsScreen = new List<Form>();
            
            TestsScreen.Add(new frmTimeFill());
            TestsScreen.Add(new frmPlaceFill());
            TestsScreen.Add(new frmSeeThreeObj());
            TestsScreen.Add(new frmThreePic());
            
            // for this screen we need some info from stage 3 so we init this stage later
            TestsScreen.Add(null);
            
            TestsScreen.Add(new frmMinus());
            TestsScreen.Add(new frmWordsHour());
            TestsScreen.Add(new frmAnalogHour());
           
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            idTest = ((frmGradesHistory)MainPanel.Controls[0]).getID();

            // Check id
            if (idTest.Length == 0)
            {
                MessageBox.Show("יש להקליד תז");
            }
            else
            {
                btn_start.Visible = false;
                btn_next.Visible = true;

                MainPanel.Controls.Clear();
                
                tmr_MainTimer.Tick += tmr_MainTimer_Tick;
                tmr_MainTimer.Start();
                
                Form subForm = TestsScreen[CurrentTest];
                subForm.TopLevel = false;
                subForm.FormBorderStyle = FormBorderStyle.None;
                MainPanel.Controls.Add(subForm);
                
                subForm.Visible = true;
            }
          
        }

        void tmr_MainTimer_Tick(object sender, EventArgs e)
        {
            TestTimesCounter[CurrentTest]++;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            
            // the words that shown at stage 3
            string[] words = null;
            
            
            // Get the grade of this level of the test
            ((frmBasicForm)TestsScreen[CurrentTest]).CheckTestGrade();
            SubTestGrades[CurrentTest] = ((frmBasicForm)TestsScreen[CurrentTest]).FinalGrade;

            CurrentTest++;

            // Check if this is the last test
            if (CurrentTest < 8)
            {
                Form subForm = TestsScreen[CurrentTest];
                
                // check if test 4 and init it
                if (subForm is frmSeeThreeObj)
                {
                    words = ((frmSeeThreeObj)subForm).Selectedword;
                    TestsScreen[4] = new ExThreeObj(words);
                    
                    // disalbe next button
                    btn_next.Enabled = false;
                    
                    // init display timer
                    tmrTemp = new Timer();
                    tmrTemp.Interval = 1000;
                    tmrTemp.Tick += tmrTemp_Tick;
                    tmrTemp.Start();
                }
           

                // test change
                subForm.TopLevel = false;
                subForm.FormBorderStyle = FormBorderStyle.None;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(subForm);
                subForm.Visible = true;
            }
            else
            {
                tmr_MainTimer.Stop();
                MessageBox.Show("המבחן תם!!!!");
                MainPanel.Controls.Clear();
                

                // Display history
                frmGradesHistory gradeHisto = new frmGradesHistory(SubTestGrades, idTest, TestTimesCounter);
                gradeHisto.TopLevel = false;
                gradeHisto.FormBorderStyle = FormBorderStyle.None;
                MainPanel.Controls.Add(gradeHisto);
                gradeHisto.Visible = true;
                btn_start.Visible = true;
                btn_next.Visible = false;
                CurrentTest = 0;
                tmr_MainTimer = new Timer();
                tmr_MainTimer.Interval = 1000;
            }
        }

        void tmrTemp_Tick(object sender, EventArgs e)
        {
            // display the screen 10 sec
            if(displayCounterStop == 10)
            {
                tmrTemp.Stop();
                btn_next.Enabled = true;
                btn_next_Click(sender, e);

            }
            else
            {
                displayCounterStop++;
            }
        }
    }
}
