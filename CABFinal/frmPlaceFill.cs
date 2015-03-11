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
    public partial class frmPlaceFill : frmBasicForm
    {
        public frmPlaceFill()
        {
            InitializeComponent();
        }

        public override void CheckTestGrade()
        {
            // Check the country
            if (cbCountry.Text == "ישראל")
            {
                FinalGrade++;
            }

            // Check the city
            if (cbCity.Text == "ראשון לציון")
            {
                FinalGrade++;
            }

            // Check the floor
            if (cbFloor.Text == "1")
            {
                FinalGrade++;
            }
            else if (cbFloor.Text == "2")
            {
                FinalGrade += 0.5;
            }
            
            // Check the floor
            if (cbBuilding.Text == "א")
            {
                FinalGrade++;
            }
            else if (cbBuilding.Text == "ב")
            {
                FinalGrade += 0.5;
            }
        }
    }
}
