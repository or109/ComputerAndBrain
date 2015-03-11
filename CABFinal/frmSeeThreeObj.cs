using System;
using System.Collections;
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
    public partial class frmSeeThreeObj : frmBasicForm
    {
        // DM
        ArrayList m_words = new ArrayList();
        Random rnd = new Random();
        public string[] Selectedword = { "", "", "" };


        public frmSeeThreeObj()
        {
            InitializeComponent();

            m_words.Add("דבק");
            m_words.Add("פיל");
            m_words.Add("קולב");
            m_words.Add("מזגן");
            m_words.Add("כיסא");
            m_words.Add("צלחת");
            m_words.Add("כבל");
            m_words.Add("רוכסן");
            m_words.Add("ארנק");
            m_words.Add("כפתור");

            // Fill the first word
            int r = rnd.Next(m_words.Count);
            lblOne.Text = m_words[r].ToString();
            m_words.RemoveAt(r);

            // Fill the second word
            r = rnd.Next(m_words.Count);
            lblTwo.Text = m_words[r].ToString();
            m_words.RemoveAt(r);

            // Fill the thired word
            r = rnd.Next(m_words.Count);
            lblThree.Text = m_words[r].ToString();

            m_words.Clear();

            Selectedword[0] = lblOne.Text;
            Selectedword[1] = lblTwo.Text;
            Selectedword[2] = lblThree.Text;
        }
    }
}
