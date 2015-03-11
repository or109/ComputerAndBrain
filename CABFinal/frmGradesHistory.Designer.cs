namespace CBFinalProject
{
    partial class frmGradesHistory
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvArc = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFinale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbDeltaTwo = new System.Windows.Forms.TextBox();
            this.tbDeltaOne = new System.Windows.Forms.TextBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArc)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(360, 11);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(134, 20);
            this.tbID.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 9);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "הצג ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "מספר ת.ז:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvArc);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 157);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dgvArc
            // 
            this.dgvArc.AllowUserToAddRows = false;
            this.dgvArc.AllowUserToDeleteRows = false;
            this.dgvArc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArc.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvArc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.time,
            this.grade,
            this.timeall});
            this.dgvArc.Location = new System.Drawing.Point(3, 3);
            this.dgvArc.Name = "dgvArc";
            this.dgvArc.ReadOnly = true;
            this.dgvArc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvArc.RowHeadersVisible = false;
            this.dgvArc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArc.ShowCellErrors = false;
            this.dgvArc.ShowCellToolTips = false;
            this.dgvArc.ShowEditingIcon = false;
            this.dgvArc.ShowRowErrors = false;
            this.dgvArc.Size = new System.Drawing.Size(361, 154);
            this.dgvArc.TabIndex = 0;
            // 
            // date
            // 
            this.date.HeaderText = "תאריך";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "שעה";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.HeaderText = "ציון כולל";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // timeall
            // 
            this.timeall.HeaderText = "זמן כולל";
            this.timeall.Name = "timeall";
            this.timeall.ReadOnly = true;
            // 
            // lblFinale
            // 
            this.lblFinale.AutoSize = true;
            this.lblFinale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFinale.Location = new System.Drawing.Point(72, 15);
            this.lblFinale.Name = "lblFinale";
            this.lblFinale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFinale.Size = new System.Drawing.Size(59, 17);
            this.lblFinale.TabIndex = 2;
            this.lblFinale.Text = "תוצאות ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 84);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "הזמן הכולל:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 53);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ציון כולל:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 115);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ציון קודם:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 144);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ציון לפני קודם:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(11, 81);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(82, 20);
            this.tbTime.TabIndex = 4;
            // 
            // tbDeltaTwo
            // 
            this.tbDeltaTwo.Location = new System.Drawing.Point(30, 141);
            this.tbDeltaTwo.Name = "tbDeltaTwo";
            this.tbDeltaTwo.ReadOnly = true;
            this.tbDeltaTwo.Size = new System.Drawing.Size(63, 20);
            this.tbDeltaTwo.TabIndex = 5;
            // 
            // tbDeltaOne
            // 
            this.tbDeltaOne.Location = new System.Drawing.Point(16, 112);
            this.tbDeltaOne.Name = "tbDeltaOne";
            this.tbDeltaOne.ReadOnly = true;
            this.tbDeltaOne.Size = new System.Drawing.Size(77, 20);
            this.tbDeltaOne.TabIndex = 6;
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(43, 50);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.ReadOnly = true;
            this.tbGrade.Size = new System.Drawing.Size(51, 20);
            this.tbGrade.TabIndex = 7;
            // 
            // GradesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(584, 226);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.tbDeltaOne);
            this.Controls.Add(this.tbDeltaTwo);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFinale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbID);
            this.Name = "GradesHistory";
            this.Text = "ציונים";
            this.Load += new System.EventHandler(this.GradesHistory_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblFinale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbDeltaTwo;
        private System.Windows.Forms.TextBox tbDeltaOne;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.DataGridView dgvArc;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeall;
    }
}