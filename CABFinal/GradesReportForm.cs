using Microsoft.Reporting.WinForms;
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
    public partial class GradesReportForm : Form
    {

        private List<ExamGrades> lstExams;


        public GradesReportForm()
        {
            InitializeComponent();
        }

        public GradesReportForm(List<ExamGrades> p_lstExam)
        {
            InitializeComponent();

            this.lstExams = p_lstExam;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.rptReport.RefreshReport();

            ReportDataSource rds = new ReportDataSource("GradesReport", this.lstExams);

            this.rptReport.LocalReport.DataSources.Clear();
            this.rptReport.LocalReport.DataSources.Add(rds);
            this.rptReport.LocalReport.Refresh();

            this.rptReport.RefreshReport();
        }
    }
}
