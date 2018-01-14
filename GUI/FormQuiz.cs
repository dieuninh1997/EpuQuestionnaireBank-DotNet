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
    public partial class FormQuiz : Form
    {
        private QuizBUS quizObj = new QuizBUS();
        private ExamBUS examObj = new ExamBUS();
        private QuestionBUS qbus = new QuestionBUS();
        private SubQuestionBUS sqbus = new SubQuestionBUS();
        private AnswerBUS abus = new AnswerBUS();

        public FormQuiz()
        {
            InitializeComponent();
        }
        //}
        private void BindGridQuiz(String t = "", String w = "", String o = "")
        {
            List<Entity.Quiz> data = quizObj.Quiz_GetByTop(t, w, o);
            dgvQuiz.DataSource = data;
            dgvQuiz.Columns["id"].HeaderText = "Quiz ID";
            dgvQuiz.Columns["quizName"].HeaderText = "Quiz name";
            dgvQuiz.Columns["quizName"].DisplayIndex = 0;
            dgvQuiz.Columns["time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvQuiz.Columns["qCountSingle"].HeaderText = "Single question";
            dgvQuiz.Columns["qCountSingle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvQuiz.Columns["qCountMultiple"].HeaderText = "Multiple question";
            dgvQuiz.Columns["qCountMultiple"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvQuiz.Columns["time"].HeaderText = "Time";
            dgvQuiz.Columns["time"].DisplayIndex = 4;
            dgvQuiz.Columns["teacherID"].HeaderText = "Teacher ID";
            dgvQuiz.Columns["teacherName"].HeaderText = "Teacher name";
            dgvQuiz.Columns["teacherName"].Visible = false;
            dgvQuiz.Columns["subjectName"].HeaderText = "Subject name";
            dgvQuiz.Columns["subjectName"].DisplayIndex = 1;
            dgvQuiz.Columns["teacherID"].Visible = false;
            dgvQuiz.Columns["id"].Visible = false;
            dgvQuiz.Columns["teacherId"].Visible = false;
            dgvQuiz.Columns["subjectId"].Visible = false;
        }
        private void BindGridExam(String t = "", String w = "", String o = "")
        {
            List<Exam> data = examObj.Exam_GetByTop(t, w, o);
            dgvExam.DataSource = data;
            dgvExam.Columns["id"].HeaderText = "#";
            dgvExam.Columns["id"].Width = 50;
            dgvExam.Columns["quizID"].Visible = false;
            dgvExam.Columns["quizName"].Visible = false;
            dgvExam.Columns["questionList"].HeaderText = "Question list";
            dgvExam.Columns["createDate"].HeaderText = "Create date";
            dgvExam.Columns["questionList"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BinCmbSubject(String t, String w, String o)
        {
            List<Subject> lst = new SubjectBUS().Subject_GetByTop(t, w, o);
            lst.Insert(0, new Subject("0", "Select an option"));
            cmbSubject.DataSource = lst;
            cmbSubject.DisplayMember = "subjectName";
            cmbSubject.ValueMember = "id";
            cmbSubject.SelectedIndex = 0;
        }
        private void BinCmbTeacher(String t, String w, String o)
        {
            List<Teacher> lst = new TeacherBUS().Teacher_GetByTop(t, w, o);
            lst.Insert(0, new Teacher("0", "--Select an option--", "", "", ""));
            
            cmbTeacher.DataSource = lst;
            cmbTeacher.DisplayMember = "name";
            cmbTeacher.ValueMember = "id";
            cmbTeacher.SelectedIndex = 0;
        }
        private void Clear()
        {
            txtSearch.Text = "";
            txtQuizID.Text = "";
            txtQuizName.Text = "";
            nbSingle.Value = 0;
            nbQuizTime.Value = 0;
            cmbSubject.SelectedIndex = 0;
            cmbTeacher.SelectedIndex = 0;
        }
        private bool ValidField()
        {
            bool check = false;
            if (txtQuizName.Text.Equals("")) check = true;
            if (nbSingle.Value <= 0) check = true;
            if (nbQuizTime.Value <= 0) check = true;
            if (cmbTeacher.SelectedIndex < 1) check = true;
            if (cmbSubject.SelectedIndex < 1) check = true;
            return check;
        }
        private void FormQuiz_Load(object sender, EventArgs e)
        {
            txtQuizID.Enabled = false;
             BindGridQuiz("", "", "");
            BinCmbSubject("", "", "");
            BinCmbTeacher("", "", "");
            BindGridExam();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();

        }

        private void lbMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out all textbox!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity. Quiz quiz = new Entity.Quiz();
            quiz.QCountSingle = (nbSingle.Value.ToString());
            quiz.QCountMultiple = (nbMulti.Value.ToString());
            quiz.Time = (nbQuizTime.Value.ToString());
            quiz.SubjectID = cmbSubject.SelectedValue.ToString();
            quiz.TeacherID = cmbTeacher.SelectedValue.ToString();
            quiz.QuizName = txtQuizName.Text;

            List<Question> lstSingle = qbus.Question_GetByTop("", "subjectID = '" + quiz.SubjectID + "' and content is null", "");
            List<Question> lstMultiple = qbus.Question_GetByTop("", "subjectID = '" + quiz.SubjectID + "' and content is not null", "");
            if (nbSingle.Value > lstSingle.Count)
            {
                MessageBox.Show("Number of single question bigger than data have", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nbMulti.Value > lstMultiple.Count)
            {
                MessageBox.Show("Number of multiple question bigger than data have", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (quizObj.Quiz_Insert(quiz) > 0)
            {
                MessageBox.Show("Insert Quiz successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insert Quiz unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            BindGridQuiz("", "", "");
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out all textbox!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Entity.Quiz quiz = new Entity.Quiz();
            quiz.QCountSingle = (nbSingle.Value.ToString());
            quiz.QCountMultiple = (nbMulti.Value.ToString());
            quiz.Time = (nbQuizTime.Value.ToString());
            quiz.SubjectID = cmbSubject.SelectedValue.ToString();
            quiz.TeacherID = cmbTeacher.SelectedValue.ToString();
            quiz.QuizName = txtQuizName.Text;
            quiz.Id = txtQuizID.Text;
            List<Question> lstSingle = qbus.Question_GetByTop("", "subjectID = '" + quiz.SubjectID + "' and content is null", "");
            List<Question> lstMultiple = qbus.Question_GetByTop("", "subjectID = '" + quiz.SubjectID + "' and content is not null", "");
            if (nbSingle.Value > lstSingle.Count)
            {
                MessageBox.Show("Number of single question bigger than data have", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nbMulti.Value > lstMultiple.Count)
            {
                MessageBox.Show("Number of multiple question bigger than data have", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (quizObj.Quiz_Update(quiz))
            {
                MessageBox.Show("Update Quiz successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Update Quiz unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            BindGridQuiz("", "", "");
            Clear();
        }

        private void btnDeleteMore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all selected item?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                int count = 0;
                foreach (DataGridViewRow r in dgvQuiz.SelectedRows)
                {
                    {
                        if (quizObj.Quiz_Delete(r.Cells["id"].Value.ToString())) { count++; }
                    }
                }
                BindGridQuiz("", "", "");
                MessageBox.Show("Successful delete " + count + " item.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtSearch.Text);
                BindGridQuiz("", " id = '" + x + "' or quizName like N'%" + x + "%'", "");
            }
            catch
            {
                BindGridQuiz("", " quizName like N'%" + txtSearch.Text + "%'", "");
            }

        }

        private void dgvQuiz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                int row = dgvQuiz.CurrentRow.Index;
                txtQuizID.Text = dgvQuiz.Rows[row].Cells[0].Value.ToString();
                txtQuizName.Text = dgvQuiz.Rows[row].Cells["quizName"].Value.ToString();
                nbSingle.Value = int.Parse(dgvQuiz.Rows[row].Cells["qCountSingle"].Value.ToString());
                nbMulti.Value = int.Parse(dgvQuiz.Rows[row].Cells["qCountMultiple"].Value.ToString());
                nbQuizTime.Value = int.Parse(dgvQuiz.Rows[row].Cells["time"].Value.ToString());
                cmbSubject.SelectedValue = dgvQuiz.Rows[row].Cells["subjectID"].Value.ToString();
                cmbTeacher.SelectedValue = dgvQuiz.Rows[row].Cells["teacherID"].Value.ToString();

                BindGridExam("", "quizID = '" + txtQuizID.Text.Trim() + "'", "");
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvQuiz_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvQuiz.ClearSelection();
                    dgvQuiz.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int x = int.Parse(txtSearch.Text);
                    BindGridQuiz("", " id = '" + x + "' or quizName like N'%" + x + "%'", "");
                }
                catch
                {
                    BindGridQuiz("", " quizName like N'%" + txtSearch.Text + "%'", "");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGridQuiz();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void mnuViewExam_Click(object sender, EventArgs e)
        {
            string content = "";
            int questionNumber = 0;
            string[] questionList = dgvExam.SelectedRows[0].Cells["questionList"].Value.ToString().Split('-');
            string[] singleQuestion = questionList[0].Split(';');
            foreach (string item in singleQuestion)
            {
                SubQuestion sq = sqbus.SubQuestion_GetByTop("", "questionID = '" + item.Trim() + "'", "").ElementAt(0);
                content += "Question " + (++questionNumber) + ". " + sq.Content + "\r\n";
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
            if (questionList.Length > 1)
            {
                singleQuestion = questionList[1].Split(';');
                foreach (string item in singleQuestion)
                {
                    Question q = qbus.Question_GetByTop("", "id='" + item.Trim() + "'", "").ElementAt(0);
                    content += "Question " + (++questionNumber) + ". " + q.Content + "\r\n";
                    List<SubQuestion> lst = sqbus.SubQuestion_GetByTop("", "questionID = '" + q.Id + "'", "");
                    foreach (SubQuestion sq in lst)
                    {
                        content += sq.Content + "\r\n";
                        List<Answer> lstAnswer = abus.Answer_GetByTop("", "subQuestionID = '" + sq.Id + "'", "");
                        for (int i = 0; i < lstAnswer.Count; ++i)
                        {
                            Answer a = lstAnswer.ElementAt(i);
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
                }
            }
            new FormViewExam(content).ShowDialog();
        }

        private void mnuDeleteExam_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Delete selected item?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                examObj.Exam_Delete(dgvExam.SelectedRows[0].Cells["id"].Value.ToString());
                BindGridExam();
            }
        }

        private void createRandomExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string subjectID = dgvQuiz.SelectedRows[0].Cells["subjectID"].Value.ToString();
                string quizID = dgvQuiz.SelectedRows[0].Cells["id"].Value.ToString();
                int singleQuesion = int.Parse(dgvQuiz.SelectedRows[0].Cells["qCountSingle"].Value.ToString());
                int multipleQuesion = int.Parse(dgvQuiz.SelectedRows[0].Cells["qCountMultiple"].Value.ToString());
                string input = Microsoft.VisualBasic.Interaction.InputBox("Number of exam will be create?", "InputBox");
                int number = 0;
                try
                {
                    number = int.Parse(input);
                    if (number <= 0)
                    {
                        MessageBox.Show("Input number must be possitive integer", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Input number wrong format", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int count = 0;
                for (int i = 0; i < number; i++)
                {
                    string questionList = createExam(subjectID, singleQuesion, multipleQuesion);
                    if (questionList != null)
                    {
                        Exam ex = new Exam();
                        ex.QuestionList = questionList;
                        ex.QuizID = quizID;
                        ex.CreateDate = DateTime.Now.ToString();
                        ex.ID = "";
                        int examID = 0;
                        if ((examID = examObj.Exam_Insert(ex)) > 0)
                        {
                            count++;
                        }
                        else
                        {

                        }
                    }
                }
                MessageBox.Show("Make " + count + " /" + number + "exam success!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridExam();
            }
            catch
            {
                return;
            }
        }
        private string createExam(string subjectID, int single, int multiple)
        {
            string questionList = "";
            List<Question> lstSingle = qbus.Question_GetByTop("", "subjectID = '" + subjectID + "' and content is null", "");
            List<Question> lstMultiple = qbus.Question_GetByTop("", "subjectID = '" + subjectID + "' and content is not null", "");
            if (single > lstSingle.Count || multiple > lstMultiple.Count)
            {
                MessageBox.Show("Number of question bigger than data have", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            Random rd = new Random();
            int randomValue = -1;
            for (int i = 0; i < single; ++i)
            {
                randomValue = rd.Next(0, lstSingle.Count - 1);
                if (questionList == "")
                    questionList += lstSingle.ElementAt(randomValue).Id;
                else
                    questionList += ";" + lstSingle.ElementAt(randomValue).Id;
                lstSingle.RemoveAt(randomValue);
            }
            if (multiple > 0) questionList += "-";
            for (int i = 0; i < multiple; ++i)
            {
                randomValue = rd.Next(0, lstMultiple.Count - 1);
                if (i == 0)
                    questionList += lstMultiple.ElementAt(randomValue).Id;
                else
                    questionList += ";" + lstMultiple.ElementAt(randomValue).Id;
                lstMultiple.RemoveAt(randomValue);
            }
            return questionList;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvQuiz.SelectedRows[0].Index < 0) return;
            try
            {
                int row = dgvQuiz.CurrentRow.Index;
                txtQuizID.Text = dgvQuiz.Rows[row].Cells[0].Value.ToString();
                txtQuizName.Text = dgvQuiz.Rows[row].Cells["quizName"].Value.ToString();
                nbSingle.Value = int.Parse(dgvQuiz.Rows[row].Cells["qCountSingle"].Value.ToString());
                nbMulti.Value = int.Parse(dgvQuiz.Rows[row].Cells["qCountMultiple"].Value.ToString());
                nbQuizTime.Value = int.Parse(dgvQuiz.Rows[row].Cells["time"].Value.ToString());
                cmbSubject.SelectedValue = dgvQuiz.Rows[row].Cells["subjectID"].Value.ToString();
                cmbTeacher.SelectedValue = dgvQuiz.Rows[row].Cells["teacherID"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvQuiz.SelectedRows[0].Index < 0) return;
            if (MessageBox.Show("Delete this quiz ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (quizObj.Quiz_Delete(dgvQuiz.SelectedRows[0].Cells["id"].Value.ToString()))
                {
                    MessageBox.Show("Delete quiz successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGridQuiz("", "", "");
                }
                else
                {
                    MessageBox.Show("Delete quiz unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
