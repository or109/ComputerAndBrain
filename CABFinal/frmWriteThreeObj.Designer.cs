namespace CBFinalProject
{
    partial class ExThreeObj
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
            this.tbThree = new System.Windows.Forms.TextBox();
            this.tbTwo = new System.Windows.Forms.TextBox();
            this.tbOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbThree
            // 
            this.tbThree.Location = new System.Drawing.Point(69, 78);
            this.tbThree.Name = "tbThree";
            this.tbThree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbThree.Size = new System.Drawing.Size(100, 20);
            this.tbThree.TabIndex = 10;
            // 
            // tbTwo
            // 
            this.tbTwo.Location = new System.Drawing.Point(253, 78);
            this.tbTwo.Name = "tbTwo";
            this.tbTwo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTwo.Size = new System.Drawing.Size(100, 20);
            this.tbTwo.TabIndex = 9;
            // 
            // tbOne
            // 
            this.tbOne.Location = new System.Drawing.Point(425, 78);
            this.tbOne.Name = "tbOne";
            this.tbOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbOne.Size = new System.Drawing.Size(100, 20);
            this.tbOne.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(122, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(332, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "5. רשום את הפריטים מסעיף 3 שים לב לסדר";
            // 
            // ExThreeObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.tbThree);
            this.Controls.Add(this.tbTwo);
            this.Controls.Add(this.tbOne);
            this.Controls.Add(this.label1);
            this.Name = "ExThreeObj";
            this.Text = "שאלה 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbThree;
        private System.Windows.Forms.TextBox tbTwo;
        private System.Windows.Forms.TextBox tbOne;
        private System.Windows.Forms.Label label1;
    }
}