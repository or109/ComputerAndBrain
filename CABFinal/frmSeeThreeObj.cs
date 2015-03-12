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
        ArrayList m_MisstakeWords = new ArrayList();
        Random rnd = new Random();
        public string[] Selectedword = { "", "", "" };
        public string[] MisstakeWords = { "", "", "", "", "", "" };


        public frmSeeThreeObj()
        {
            InitializeComponent();

            m_words.Add("דבק");
            m_words.Add("פיל");
            m_words.Add("קולב");
            m_words.Add("מזגן");
            m_words.Add("לוח");
            m_words.Add("צלחת");
            m_words.Add("כבל");
            m_words.Add("רוכסן");
            m_words.Add("ארנק");
            m_words.Add("כפתור");

            m_MisstakeWords.Add("דבך");
            m_MisstakeWords.Add("דבכ");
            m_MisstakeWords.Add("פייל");
            m_MisstakeWords.Add("פיייל");
            m_MisstakeWords.Add("כולב");
            m_MisstakeWords.Add("קוולב");
            m_MisstakeWords.Add("מגזן");
            m_MisstakeWords.Add("מזגנ");
            m_MisstakeWords.Add("לוך");
            m_MisstakeWords.Add("לח");
            m_MisstakeWords.Add("צלכת");
            m_MisstakeWords.Add("צלחט");
            m_MisstakeWords.Add("קבל");
            m_MisstakeWords.Add("כול");
            m_MisstakeWords.Add("רוכשן");
            m_MisstakeWords.Add("רוקסן");
            m_MisstakeWords.Add("הרנק");
            m_MisstakeWords.Add("ערנק");
            m_MisstakeWords.Add("קפתור");
            m_MisstakeWords.Add("כפטור");

            // Fill the first word
            int r = rnd.Next(m_words.Count);
            lblOne.Text = m_words[r].ToString();
            m_words.RemoveAt(r);

            MisstakeWords[0] = m_MisstakeWords[r * 2].ToString();
            m_MisstakeWords.RemoveAt(r * 2);
            MisstakeWords[1] = m_MisstakeWords[r * 2].ToString();
            m_MisstakeWords.RemoveAt(r * 2);

            // Fill the second word
            r = rnd.Next(m_words.Count);
            lblTwo.Text = m_words[r].ToString();
            m_words.RemoveAt(r);

            MisstakeWords[2] = m_MisstakeWords[r * 2].ToString();
            m_MisstakeWords.RemoveAt(r * 2);
            MisstakeWords[3] = m_MisstakeWords[r * 2].ToString();
            m_MisstakeWords.RemoveAt(r * 2);

            // Fill the thired word
            r = rnd.Next(m_words.Count);
            lblThree.Text = m_words[r].ToString();

            MisstakeWords[4] = m_MisstakeWords[r * 2].ToString();
            m_MisstakeWords.RemoveAt(r * 2);
            MisstakeWords[5] = m_MisstakeWords[r * 2].ToString();
            m_MisstakeWords.RemoveAt(r * 2);

            m_words.Clear();

            Selectedword[0] = lblOne.Text;
            Selectedword[1] = lblTwo.Text;
            Selectedword[2] = lblThree.Text;
        }
    }
}
