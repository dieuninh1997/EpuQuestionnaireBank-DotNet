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
using System.IO;

namespace GUI
{
    public partial class FormTeacher : Form
    {
        private string imgLoc = "";
        private TeacherBUS obj = new TeacherBUS();


        public FormTeacher()
        {
            InitializeComponent();
        }

        private void BinData(String t, String w, String o)
        {
            dgvTeacher.DataSource = obj.Teacher_GetByTop(t, w, o);
            MessageBox.Show("Size=" + obj.Teacher_GetByTop(t, w, o).Count);
            dgvTeacher.Columns["id"].HeaderText = "Teacher ID";
            dgvTeacher.Columns["name"].HeaderText = "Teacher name";
            dgvTeacher.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTeacher.Columns["username"].HeaderText = "Username";
            dgvTeacher.Columns["password"].HeaderText = "Password";
            dgvTeacher.Columns["password"].Visible = false;
            dgvTeacher.Columns["avatar"].HeaderText = "Avatar";
            dgvTeacher.Columns["avatar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          
           
        }

        private void Clear()
        {
            txtSearch.Text = "";
            txtTeacherID.Text = "";
            txtTeacherName.Text = "";
            txtUserName.Text = "";
            picAvatar.Image = picAvatar.InitialImage;
            txtPassword.Text = "";
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            BinData(" ", " ", " ");
        }

        private bool ValidField()
        {
            return txtTeacherName.Text.Equals(String.Empty) ? true : false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out textbox Teacher Name!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            byte[] img = null;
            FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            Teacher teacher = new Teacher(txtTeacherID.Text, txtTeacherName.Text, txtUserName.Text, txtPassword.Text, imgLoc);
            if (obj.Teacher_Insert(teacher))
            {
                MessageBox.Show("Insert teacher successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BinData(" ", " ", " ");
            }
            else
            {
                MessageBox.Show("Insert teacher unsuccessed!\nNote: Username must be unique", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtSearch.Text);
                BinData(" ", " id = '" + x + "' or name like N'%" + x + "%' or username like '%" + x + "%'", " ");
            }
            catch
            {
                BinData(" ", " name like N'%" + txtSearch.Text + "%' or username like'%" + txtSearch.Text + "%'", " ");
            }
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                dlg.Title = "Select Teacher Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picAvatar.ImageLocation = imgLoc;
                }
            }
            catch
            {
                MessageBox.Show("No Brower", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BinData("", "", "");
        }

        private void btnDeleteMore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want delete item selected ?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                int count = 0;
                foreach (DataGridViewRow r in dgvTeacher.SelectedRows)
                {
                    {
                        if (obj.Teacher_Delete(r.Cells["id"].Value.ToString())) { count++; }
                    }
                }
                BinData(" ", " ", " ");
                MessageBox.Show("Deleted success " + count + " item.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows[0].Index < 0)
            {
                return;
            }
            int row = dgvTeacher.SelectedRows[0].Index;
            try
            {
                txtTeacherID.Text = dgvTeacher.Rows[row].Cells[0].Value.ToString();
                txtTeacherName.Text = dgvTeacher.Rows[row].Cells["name"].Value.ToString();
                txtUserName.Text = dgvTeacher.Rows[row].Cells[2].Value.ToString();
                txtPassword.Text = dgvTeacher.Rows[row].Cells[3].Value.ToString();
                picAvatar.Image = System.Drawing.Image.FromFile(dgvTeacher.Rows[row].Cells["avatar"].Value.ToString());
            }
            catch
            {
                picAvatar.Image = picAvatar.ErrorImage;
            }
        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int row = e.RowIndex;
            try
            {
                txtTeacherID.Text = dgvTeacher.Rows[row].Cells[0].Value.ToString();
                txtTeacherName.Text = dgvTeacher.Rows[row].Cells[1].Value.ToString();
                txtUserName.Text = dgvTeacher.Rows[row].Cells[2].Value.ToString();
                txtPassword.Text = dgvTeacher.Rows[row].Cells[3].Value.ToString();
                picAvatar.Image = System.Drawing.Image.FromFile(dgvTeacher.Rows[row].Cells["avatar"].Value.ToString());
            }
            catch
            {
                picAvatar.Image = picAvatar.ErrorImage;
            }
        }

        private void dgvTeacher_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvTeacher.ClearSelection();
                    dgvTeacher.Rows[e.RowIndex].Selected = true;
                }
            }

        }

        private void ckbShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPwd.Checked == true) txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
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

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
