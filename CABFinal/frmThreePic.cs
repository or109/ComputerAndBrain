using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBFinalProject
{
    public partial class frmThreePic : frmBasicForm
    {
        public string[] CurrentPic = { "", "", "" };


        public frmThreePic()
        {
            InitializeComponent();

            Hashtable htPics = new Hashtable();
            htPics.Add("1", "בובה");
            htPics.Add("2", "כבל");
            htPics.Add("3", "אבן");
            htPics.Add("4", "אופניים");
            htPics.Add("5", "מכונית");
            htPics.Add("6", "תפוז");
            htPics.Add("7", "נחש");
            htPics.Add("8", "מחשב");
            htPics.Add("9", "מוח");
            htPics.Add("0", "מקלדת");

            Random rnd = new Random();


            // Fill the first Pic
            int r = rnd.Next(htPics.Keys.Count);

            pbOne.Image = Image.FromFile(@"C:\לימודים\פרוייקט סיכום המחשב והמוח\CABFinal\bin\Pics\" + r.ToString() +".jpg");
            CurrentPic[0] = htPics[r.ToString()].ToString();


            // Fill the second Pic
            r = rnd.Next(htPics.Keys.Count);
            pbTwo.Image = Image.FromFile(@"C:\לימודים\פרוייקט סיכום המחשב והמוח\CABFinal\bin\Pics\" + r.ToString() + ".jpg");
            CurrentPic[1] = htPics[r.ToString()].ToString();

            // Fill the thired Pic
            r = rnd.Next(htPics.Keys.Count);
            pbThree.Image = Image.FromFile(@"C:\לימודים\פרוייקט סיכום המחשב והמוח\CABFinal\bin\Pics\" + r.ToString() + ".jpg");
            CurrentPic[2] = htPics[r.ToString()].ToString();
            
            htPics.Clear();

        }

        public override void CheckTestGrade()
        {
            if(tbOne.Text == CurrentPic[0])
            {
                FinalGrade++;
            }
            if (tbTwo.Text == CurrentPic[1])
            {
                FinalGrade++;
            }
            if (tbThree.Text == CurrentPic[2])
            {
                FinalGrade++;
            }
        }
    }
}
