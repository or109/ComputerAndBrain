namespace CBFinalProject
{
    partial class frmAnalogHour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalogHour));
            this.tbHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOne = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(70, 58);
            this.tbHour.Name = "tbHour";
            this.tbHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbHour.Size = new System.Drawing.Size(190, 20);
            this.tbHour.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(377, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "8. רשום את השעה שמופיעה בתמונה בפורמט 12H:";
            // 
            // pbOne
            // 
            this.pbOne.Image = ((System.Drawing.Image)(resources.GetObject("pbOne.Image")));
            this.pbOne.Location = new System.Drawing.Point(303, 43);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(149, 105);
            this.pbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOne.TabIndex = 7;
            this.pbOne.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(58, 96);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "לדוגמא: 10:30";
            // 
            // ExAnalogHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.pbOne);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExAnalogHour";
            this.Text = "שאלה 8";
            ((System.ComponentModel.ISupportInitialize)(this.pbOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOne;
        private System.Windows.Forms.Label label2;
    }
}