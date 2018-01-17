﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BUS;

namespace GUI
{
    public partial class FormStudent : Form
    {
        private StudentBUS obj = new StudentBUS();
        public FormStudent()
        {
            InitializeComponent();
        }
        private void BindData(String t = "", String w = "", String o = "")
        {
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.MultiSelect = true;
            dgvStudent.BackgroundColor = Color.White;
            dgvStudent.ReadOnly = true;
            List<Student> data = obj.Student_GetByTop(t, w, o);
            dgvStudent.DataSource = data;
            dgvStudent.Columns[0].HeaderText = "Student ID";
            dgvStudent.Columns[0].Width = 120;
            dgvStudent.Columns[1].HeaderText = "Student name";
            dgvStudent.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStudent.Columns[2].HeaderText = "Username";
            dgvStudent.Columns[3].Visible = false;
            dgvStudent.Columns[4].HeaderText = "Class ID";
            dgvStudent.Columns[4].Visible = false;
            dgvStudent.Columns[5].HeaderText = "Status";
            dgvStudent.Columns[6].HeaderText = "Class name";
            dgvStudent.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void BinCmbClass(String t, String w, String o)
        {
            List<Class> lst = new ClassBUS().Class_GetByTop(t, w, o);
            lst.Insert(0, new Entity.Class("0", "Select an option", ""));
            cmbClassID.DataSource = lst;
            cmbClassID.DisplayMember = "className";
            cmbClassID.ValueMember = "id";
            cmbClassID.SelectedIndex = 0;
        }
        private void BinCmbFilter(String t, String w, String o)
        {
            List<Class> lst = new ClassBUS().Class_GetByTop(t, w, o);
            lst.Insert(0, new Entity.Class("0", "Select an option", ""));
            cmbFilter.DataSource = lst;
            cmbFilter.DisplayMember = "className";
            cmbFilter.ValueMember = "id";
            cmbFilter.SelectedIndex = 0;
        }
        private void Clear()
        {
            txtSearch.Text = "";
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            rdActive.Checked = true;
            cmbClassID.SelectedIndex = 0;
        }
        private bool ValidField()
        {
            bool check = false;
            if (txtStudentName.Text.Equals("")) check = true;
            if (txtUserName.Text.Equals("")) check = true;
            if (txtPassword.Text.Equals("")) check = true;
            if (cmbClassID.SelectedIndex < 1) check = true;
            return check;
        }
        private void FormStudent_Load(object sender, EventArgs e)
        {
            BindData("", "", "");
            BinCmbClass("", "", "");
            BinCmbFilter("", "", "");
            txtStudentID.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out all textbox!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Student Student = new Student(txtStudentID.Text, txtStudentName.Text, txtUserName.Text, txtPassword.Text, cmbClassID.SelectedValue.ToString(), (rdActive.Checked ? "True" : "False"));
            if (obj.Student_Insert(Student))
            {
                MessageBox.Show("Insert Student successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insert Student unsuccessed!\nNote: Username must be unique", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            BindData("", "", "");
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out all textbox!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Student Student = new Student(txtStudentID.Text, txtStudentName.Text, txtUserName.Text, txtPassword.Text, cmbClassID.SelectedValue.ToString(), (rdActive.Checked ? "True" : "False"));
            if (obj.Student_Update(Student))
            {
                MessageBox.Show("Update Student successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("update Student unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            BindData("", "", "");
            Clear();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            Clear();
            BindData("", "", "");
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                int row = dgvStudent.CurrentRow.Index;
                txtStudentID.Text = dgvStudent.Rows[row].Cells[0].Value.ToString();
                txtStudentName.Text = dgvStudent.Rows[row].Cells[1].Value.ToString();
                txtUserName.Text = dgvStudent.Rows[row].Cells[2].Value.ToString();
                txtPassword.Text = dgvStudent.Rows[row].Cells[3].Value.ToString();
                cmbClassID.SelectedValue = dgvStudent.Rows[row].Cells[4].Value.ToString();
                if (dgvStudent.Rows[row].Cells[5].Value.ToString().ToLower() == "true")
                    rdActive.Checked = true;
                else rdBlock.Checked = true;
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int x = int.Parse(txtSearch.Text);
                    BindData("", " id = '" + x + "' or fullname like N'%" + x + "%'", "");
                }
                catch
                {
                    BindData("", " fullname like N'%" + txtSearch.Text + "%'", "");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void btnDeleteMore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all selected item?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                int count = 0;
                foreach (DataGridViewRow r in dgvStudent.SelectedRows)
                {
                    {
                        if (obj.Student_Delete(r.Cells["id"].Value.ToString())) { count++; }
                    }
                }
                BindData("", "", "");
                MessageBox.Show("Successful delete " + count + " item.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows[0].Index < 0) return;
            try
            {
                int row = dgvStudent.SelectedRows[0].Index;
                txtStudentID.Text = dgvStudent.Rows[row].Cells[0].Value.ToString();
                txtStudentName.Text = dgvStudent.Rows[row].Cells[1].Value.ToString();
                txtUserName.Text = dgvStudent.Rows[row].Cells[2].Value.ToString();
                txtPassword.Text = dgvStudent.Rows[row].Cells[3].Value.ToString();
                cmbClassID.SelectedValue = dgvStudent.Rows[row].Cells[4].Value.ToString();
                if (dgvStudent.Rows[row].Cells[5].Value.ToString().ToLower() == "true")
                    rdActive.Checked = true;
                else rdBlock.Checked = true;
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows[0].Index < 0) return;
            if (MessageBox.Show("Deleteall all selected student ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int count = 0;
                foreach (DataGridViewRow dr in dgvStudent.SelectedRows)
                {
                    if (obj.Student_Delete(dr.Cells["id"].Value.ToString()))
                    {
                        count++;
                    }
                    else
                    {
                    }
                }
                MessageBox.Show("Delete " + count + " student successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindData("", "", "");

            }
        }

        private void ckbShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPwd.Checked) txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            BindData();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 0)
            {
                BindData();
            }
            else
            {
                BindData("", "classID = '" + cmbFilter.SelectedValue.ToString() + "'", "");
            }
        }

        private void menuGenAccount_Click(object sender, EventArgs e)
        {
            int count = 0;
            string userPrefix = Microsoft.VisualBasic.Interaction.InputBox("Username prefix?", "InputBox");
            string passPrefix = Microsoft.VisualBasic.Interaction.InputBox("Password prefix?", "InputBox");
            foreach (DataGridViewRow dr in dgvStudent.SelectedRows)
            {
                Student st = new Student();
                st.Id = dr.Cells["id"].Value.ToString();
                st.Fullname = dr.Cells["fullname"].Value.ToString();
                st.Username = userPrefix + st.Id;
                st.Password = passPrefix + st.Id;
                st.Status = dr.Cells["status"].Value.ToString();
                st.ClassID = dr.Cells["classID"].Value.ToString();
                if (obj.Student_Update(st)) count++;
            }
            MessageBox.Show("Generate " + count + " student account successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindData("", "", "");
        }

        private void FormStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }
    }
}
