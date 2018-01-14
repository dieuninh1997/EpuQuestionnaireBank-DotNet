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
    public partial class FormSubject : Form
    {

        private SubjectBUS obj = new SubjectBUS();
        public FormSubject()
        {
            InitializeComponent();
        }
        private void BindData(String t = "", String w = "", String o = "")
        {
            var lst = obj.Subject_GetByTop(t, w, o);
            dgvSubject.DataSource = lst;
            dgvSubject.Columns[0].HeaderText = "Subject ID";
            dgvSubject.Columns[1].HeaderText = "Subject name";
            dgvSubject.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MessageBox.Show("Size=" + lst.Count);
        }
        private void Clear()
        {
            txtSearch.Text = "";
            txtSubjectID.Text = "";
            txtSubjectName.Text = "";
        }
        private bool ValidField()
        {
            return txtSubjectName.Text.Equals(String.Empty) ? true : false;
        }

     

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int x = int.Parse(txtSearch.Text);
                    BindData("", " id = '" + x + "' or subjectName like N'%" + x + "%'", "");
                }
                catch
                {
                    BindData("", " subjectName like N'%" + txtSearch.Text + "%'", "");
                }
            }
        }
        private void FormSubject_Load(object sender, EventArgs e)
        {
            txtSubjectID.Enabled = false;
            BindData("", "", "");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out textbox Subject Name!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Subject subject = new Subject(txtSubjectID.Text, txtSubjectName.Text);
            if (obj.Subject_Insert(subject))
            {
                MessageBox.Show("Insert faculty successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insert faculty unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
            BindData("", "", "");
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out textbox Subject Name!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Subject subject = new Subject(txtSubjectID.Text, txtSubjectName.Text);
            if (obj.Subject_Update(subject))
            {
                MessageBox.Show("Update faculty successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("update faculty unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            BindData("", "", "");
            Clear();
        }

        private void btnDeleteMore_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Delete all selected item?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                int count = 0;
                foreach (DataGridViewRow r in dgvSubject.SelectedRows)
                {
                    {
                        if (obj.Subject_Delete(r.Cells["id"].Value.ToString())) { count++; }
                    }
                }
                BindData("", "", "");
                MessageBox.Show("Successful delete " + count + " item.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtSearch.Text);
                BindData("", " id = '" + x + "' or subjectName like N'%" + x + "%'", "");
            }
            catch
            {
                BindData("", " subjectName like N'%" + txtSearch.Text + "%'", "");
            }
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvSubject.CurrentRow.Index;
                txtSubjectID.Text = dgvSubject.Rows[row].Cells[0].Value.ToString();
                txtSubjectName.Text = dgvSubject.Rows[row].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSubject_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvSubject.ClearSelection();
                    dgvSubject.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
    }
}
