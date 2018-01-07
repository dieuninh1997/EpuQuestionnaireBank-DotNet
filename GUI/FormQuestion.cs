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

namespace GUI
{
    public partial class FormQuestion : Form
    {
        private QuestionBUS qbus = new QuestionBUS();
        private SubQuestionBUS sqbus = new SubQuestionBUS();
        private AnswerBUS abus = new AnswerBUS();
        private bool isReport = false;
        public FormQuestion()
        {
            InitializeComponent();
            BindQuestionData();
        }
      
        private void BindQuestionData(string t = "", string w = "", string o = "")
        {

            dgvQuestion.DataSource = new QuestionBUS().Question_GetByTop(t, w, o);
            dgvQuestion.Columns["id"].DisplayIndex = 0;
            dgvQuestion.Columns["id"].HeaderText = "#";
            dgvQuestion.Columns["subjectID"].Visible = false;
            dgvQuestion.Columns["subjectName"].HeaderText = "Subject";
            dgvQuestion.Columns["subjectName"].DisplayIndex = 1;
            dgvQuestion.Columns["subjectName"].Width = 160;
            dgvQuestion.Columns["content"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvQuestion.Columns["content"].HeaderText = "Question";
            dgvQuestion.Columns["content"].DisplayIndex = 2;
            dgvQuestion.Columns["createDate"].DisplayIndex = 3;
            dgvQuestion.Columns["createDate"].HeaderText = "Creat date";
        }

        private void BindSubQuestionData(string t = "", string w = "", string o = "")
        {
            if (isReport) o = " reportCount desc";
            dgvSubQuestion.DataSource = new SubQuestionBUS().SubQuestion_GetByTop(t, w, o);
            dgvSubQuestion.Columns["id"].DisplayIndex = 0;
            dgvSubQuestion.Columns["id"].HeaderText = "#";
            dgvSubQuestion.Columns["questionID"].Visible = false;
            dgvSubQuestion.Columns["content"].HeaderText = "Sub question";
            dgvSubQuestion.Columns["content"].DisplayIndex = 1;
            dgvSubQuestion.Columns["content"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSubQuestion.Columns["reportCount"].HeaderText = "Report";
            dgvSubQuestion.Columns["reportCount"].DisplayIndex = 2;
            if (isReport) dgvSubQuestion.Columns["reportCount"].DefaultCellStyle.BackColor = Color.Gray;
            dgvSubQuestion.Columns["active"].DisplayIndex = 3;
            dgvSubQuestion.Columns["active"].HeaderText = "Active";
        }
        private void BindAnswerData(List<Answer> lst = null, string t = "", string w = "", string o = "")
        {

            if (lst == null)
            {
                dgvAnswer.DataSource = new AnswerBUS().Answer_GetByTop(t, w, o);
            }
            else
            {
                dgvAnswer.DataSource = lst;
            }
            dgvAnswer.Columns["id"].DisplayIndex = 0;
            dgvAnswer.Columns["id"].HeaderText = "#";
            dgvAnswer.Columns["subQuestionID"].Visible = false;
            dgvAnswer.Columns["answers"].HeaderText = "Answer";
            dgvAnswer.Columns["answers"].DisplayIndex = 1;
            dgvAnswer.Columns["answers"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAnswer.Columns["isCorrect"].HeaderText = "Correct";
            dgvAnswer.Columns["isCorrect"].DisplayIndex = 2;
        }


        private void BindCmbSubject()
        {
            List<Subject> lst = new SubjectBUS().Subject_GetByTop("", "", "");
            lst.Insert(0, new Subject("0", "-- Select All --"));
            cmbSubject.DataSource = lst;
            cmbSubject.DisplayMember = "subjectName";
            cmbSubject.ValueMember = "ID";
            cmbSubject.SelectedIndex = 0;
        }



        private void FormQuestion_Load(object sender, EventArgs e)
        {
            BindCmbSubject();
            //BindSubQuestionData();
            //BindAnswerData();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == 0)
            {
                BindQuestionData("", "", "");
            }
            else
            {
                BindQuestionData("", "subjectID = '" + cmbSubject.SelectedValue.ToString() + "'", "");
            }
        }

        private void dgvQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string txtView = "";
            int row = e.RowIndex;
            if (row < 0) return;
            string qID = dgvQuestion.Rows[row].Cells["id"].Value.ToString();
            List<SubQuestion> lstSub = sqbus.SubQuestion_GetByTop("", "questionID = '" + qID + "'", "");
            BindSubQuestionData("", "questionID='" + qID + "'", "");
            List<Answer> lstAnswer = new List<Answer>();
            if (dgvQuestion.Rows[row].Cells["content"].Value.ToString() != "")
            {
                txtView += dgvQuestion.Rows[row].Cells["content"].Value.ToString() + "\r\n";
            }
            foreach (SubQuestion sq in lstSub)
            {
                txtView += "Question: " + sq.Content + "\r\n";
                List<Answer> lst = abus.Answer_GetByTop("", "subQuestionID = '" + sq.Id + "'", "");
                for (int i = 0; i < lst.Count; i++)
                {
                    Answer ans = lst.ElementAt(i);
                    lstAnswer.Add(ans);
                    if (ans.IsCorrect == "True")
                    {
                        txtView += "    " + (char)(65 + i) + ". " + ans.Answers + " *\r\n";
                    }
                    else
                    {
                        txtView += "    " + (char)(65 + i) + ". " + ans.Answers + "\r\n";
                    }
                }
                txtView += "\r\n";
            }
            txtDisplay.Text = txtView;

            BindAnswerData(lstAnswer);
        }

        private void dgvSubQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;
            string subID = dgvSubQuestion.Rows[row].Cells["id"].Value.ToString();
            BindAnswerData(null, "", "subQuestionID = '" + subID + "'", "");
            BindQuestionData("", "id='" + dgvSubQuestion.Rows[row].Cells["questionID"].Value.ToString() + "'", "");
        }

        private void dgvAnswer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormQuestionDetail().ShowDialog();
        }

        private void dgvQuestion_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvQuestion.ClearSelection();
                    dgvQuestion.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindQuestionData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindSubQuestionData("", "content like N'%" + txtSearch.Text + "%'", "");
            BindQuestionData("", "content like N'%" + txtSearch.Text + "%'", "");

        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
