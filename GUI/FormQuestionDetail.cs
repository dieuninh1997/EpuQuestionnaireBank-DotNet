using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Entity;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class FormQuestionDetail : Form
    {
        private QuestionBUS qbus = new QuestionBUS();
        private SubQuestionBUS sqbus = new SubQuestionBUS();
        private AnswerBUS abus = new AnswerBUS();
        private bool _isEdit = false;
        private string _qid = "";

        public FormQuestionDetail(bool isEdit = false, bool isSingle = true, string selectedValue = "0", string qID = "")
        {
            InitializeComponent();
            BindCmbSubject();

            if (isEdit)
            {
                _isEdit = true;
                _qid = qID;
                if (isSingle)
                {
                    rdSingle.Checked = true;
                    rdMulti.Enabled = false;
                }
                else
                {
                    rdMulti.Checked = true;
                    rdSingle.Enabled = false;
                }

                cmbSubject.SelectedValue = selectedValue;
                cmbSubject.Enabled = false;
                txtView.Text = GetContentQuestion();
                btnUpdate.Text = "Update";
              //  btnUpdate.Image = System.Drawing.Image.FromFile("D:\\EPU\\c#\\Quiz\\Source\\Server\\Quiz\\Resources\\edit.png");
            }
        }

        private string GetContentQuestion()
        {
            string content = "";
            Question q = qbus.Question_GetByTop("", "id = '" + _qid + "'", "").ElementAt(0);
            List<SubQuestion> lstSub = sqbus.SubQuestion_GetByTop("", "questionID = '" + _qid + "'", "");
            if (lstSub.Count > 1) rdSingle.Checked = false;

            if (!rdSingle.Checked)
            {
                content = q.Content + "\r\n";
            }
            foreach (SubQuestion sq in lstSub)
            {
                content += sq.Content + "\r\n";
                List<Answer> lst = abus.Answer_GetByTop("", "subQuestionID = '" + sq.Id + "'", "");
                for (int i = 0; i < lst.Count; ++i)
                {
                    Answer a = lst.ElementAt(i);
                    if (a.IsCorrect.ToLower() == "true")
                    {
                        content += (char)(65 + i) + ". " + a.Answers + " *\r\n";
                    }
                    else
                    {
                        content += (char)(65 + i) + ". " + a.Answers + "\r\n";
                    }
                }
                content += "\r\n";
            }
            return content;
        }
        private void BindCmbSubject()
        {
            List<Subject> lst = new SubjectBUS().Subject_GetByTop("", "", "");
            lst.Insert(0, new Subject("0", "-- Select Subject --"));
            cmbSubject.DataSource = lst;
            cmbSubject.DisplayMember = "subjectName";
            cmbSubject.ValueMember = "id";
            cmbSubject.SelectedIndex = 0;
        }

        public FormQuestionDetail()
        {
            InitializeComponent();
        }

        private void FormQuestionDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            new FormQuestionGuide().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close without save?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private bool CheckSingleQuestion()
        {
            string s = txtView.Text.Trim();
            string[] temp = Regex.Split(s, "\r\n");
            if (temp.Length < 3)
            {
                MessageBox.Show("Num of answer must be more than 1", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int c = 0;
            foreach (string str in temp)
            {
                if (str.Trim() == string.Empty) return false;
                if (str.Trim().EndsWith("*")) c++;
            }
            if (c == temp.Length - 1)
            {
                MessageBox.Show("Need at least 1 uncorrect answer", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (c == 0)
            {
                MessageBox.Show("Need at least 1 correct answer", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtView.SelectAll();
            }
        }
    }
}
