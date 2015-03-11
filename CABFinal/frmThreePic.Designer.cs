namespace CBFinalProject
{
    partial class frmThreePic
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
            this.pbThree = new System.Windows.Forms.PictureBox();
            this.pbTwo = new System.Windows.Forms.PictureBox();
            this.pbOne = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).BeginInit();
            this.SuspendLayout();
            // 
            // tbThree
            // 
            this.tbThree.Location = new System.Drawing.Point(128, 135);
            this.tbThree.Name = "tbThree";
            this.tbThree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbThree.Size = new System.Drawing.Size(100, 20);
            this.tbThree.TabIndex = 6;
            // 
            // tbTwo
            // 
            this.tbTwo.Location = new System.Drawing.Point(258, 135);
            this.tbTwo.Name = "tbTwo";
            this.tbTwo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTwo.Size = new System.Drawing.Size(100, 20);
            this.tbTwo.TabIndex = 5;
            // 
            // tbOne
            // 
            this.tbOne.Location = new System.Drawing.Point(387, 135);
            this.tbOne.Name = "tbOne";
            this.tbOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbOne.Size = new System.Drawing.Size(100, 20);
            this.tbOne.TabIndex = 4;
            // 
            // pbThree
            // 
            this.pbThree.Location = new System.Drawing.Point(128, 37);
            this.pbThree.Name = "pbThree";
            this.pbThree.Size = new System.Drawing.Size(100, 92);
            this.pbThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThree.TabIndex = 3;
            this.pbThree.TabStop = false;
            // 
            // pbTwo
            // 
            this.pbTwo.Location = new System.Drawing.Point(258, 37);
            this.pbTwo.Name = "pbTwo";
            this.pbTwo.Size = new System.Drawing.Size(100, 92);
            this.pbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTwo.TabIndex = 2;
            this.pbTwo.TabStop = false;
            // 
            // pbOne
            // 
            this.pbOne.Location = new System.Drawing.Point(387, 37);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(100, 92);
            this.pbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOne.TabIndex = 1;
            this.pbOne.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "4.רשום מה הינך רואה בתמונות הבאות";
            // 
            // frmThreePic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.tbThree);
            this.Controls.Add(this.tbTwo);
            this.Controls.Add(this.tbOne);
            this.Controls.Add(this.pbThree);
            this.Controls.Add(this.pbTwo);
            this.Controls.Add(this.pbOne);
            this.Controls.Add(this.label1);
            this.Name = "frmThreePic";
            this.Text = "שאלה 4";
            ((System.ComponentModel.ISupportInitialize)(this.pbThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOne;
        private System.Windows.Forms.PictureBox pbTwo;
        private System.Windows.Forms.PictureBox pbThree;
        private System.Windows.Forms.TextBox tbOne;
        private System.Windows.Forms.TextBox tbTwo;
        private System.Windows.Forms.TextBox tbThree;
    }
}