using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBFinalProject
{
    public class frmBasicForm: Form
    {

        public double FinalGrade { get; set; }

        public frmBasicForm()
        {
            FinalGrade = 0;
        }

        virtual public void CheckTestGrade() { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "OurForm";
            this.ResumeLayout(false);
        }
    }
}
