﻿namespace CBFinalProject
{
    partial class GradesReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExamBindingSource)).BeginInit();
            this.SuspendLayout();




            this.rptReport.AutoSize = true;
            this.rptReport.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GradesReport";
            reportDataSource1.Value = this.ExamBindingSource;
            this.rptReport.LocalReport.DataSources.Add(reportDataSource1);
            this.rptReport.LocalReport.ReportEmbeddedResource = "CBFinalProject.GradesReport.rdlc";
            this.rptReport.Location = new System.Drawing.Point(0, 0);
            this.rptReport.Name = "rptReport";
            this.rptReport.Size = new System.Drawing.Size(1052, 615);
            this.rptReport.TabIndex = 0;




            // 
            this.ExamBindingSource.DataSource = typeof(CBFinalProject.ExamGrades);
            // 
            
            
            
            
            
            // 
            // GradesReportForm
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 615);
            this.Controls.Add(this.rptReport);
            this.Name = "GradesReportForm";
            this.Text = "GradesReport";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion


        private Microsoft.Reporting.WinForms.ReportViewer rptReport;
        private System.Windows.Forms.BindingSource ExamBindingSource;
    }
}