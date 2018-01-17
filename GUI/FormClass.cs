using System;
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
    public partial class FormClass : Form
    {
        private ClassBUS obj = new ClassBUS();
        public FormClass()
        {
            InitializeComponent();
        }
        private void BinData(String t = "", String w = "", String o = "")
        {
            dgvClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClass.AllowUserToAddRows = false;
            dgvClass.AllowUserToDeleteRows = false;
            dgvClass.MultiSelect = false;
            dgvClass.BackgroundColor = Color.White;
            dgvClass.ReadOnly = true;
            List<Class> data = obj.Class_GetByTop(t, w, o);
            dgvClass.DataSource = data;
            dgvClass.Columns[0].HeaderText = "Class ID";
            dgvClass.Columns[1].HeaderText = "Class name";
            dgvClass.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Hide column ID. Just use for update, fill, ...
            dgvClass.Columns[2].HeaderText = "Faculty ID";
            dgvClass.Columns[2].Visible = false;

            dgvClass.Columns[3].HeaderText = "Faculty name";
            dgvClass.Columns[3].Width = 150;
            dgvClass.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Clear()
        {
            txtClassID.Text = "";
            txtClassName.Text = "";
            cmbFacultyID.SelectedIndex = 0;
            txtSearch.Text = "";
        }

        private void BinCmbFaculty(String t, String w, String o)
        {
            List<Entity.Faculty> lst = new FacultyBUS().Faculty_GetByTop(t, w, o);
            lst.Insert(0, new Faculty("0", "-- Select an option --"));
            cmbFacultyID.DataSource = lst;
            cmbFacultyID.DisplayMember = "facultyName";
            cmbFacultyID.ValueMember = "id";
            cmbFacultyID.SelectedIndex = 0;
        }
        private bool ValidField()
        {
            bool check = false;
            if (txtClassName.Text.Equals("")) check = true;
            if (cmbFacultyID.SelectedIndex < 1) check = true;
            return check;
        }
        private void FormClass_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out all textbox!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Class Class = new Class(txtClassID.Text, txtClassName.Text, cmbFacultyID.SelectedValue.ToString());
            if (obj.Class_Insert(Class))
            {
                MessageBox.Show("Insert Class successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BinData();
                Clear();
            }
            else
            {
                MessageBox.Show("Insert Class unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out all textbox!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Class Class = new Class(txtClassID.Text, txtClassName.Text, cmbFacultyID.SelectedValue.ToString());

            if (obj.Class_Update(Class))
            {
                MessageBox.Show("Update Class successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("update Class unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            BinData("", "", "");
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int x = int.Parse(txtSearch.Text);
                    BinData("", " id = '" + x + "' or className like N'%" + x + "%'", "");
                }
                catch
                {
                    BinData("", " className like N'%" + txtSearch.Text + "%'", "");
                }
            }
        }

        private void FormClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BinData();
        }

        private void btnDeleteMore_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Delete all selected item?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                int count = 0;
                foreach (DataGridViewRow r in dgvClass.SelectedRows)
                {
                    {
                        if (obj.Class_Delete(r.Cells["id"].Value.ToString())) { count++; }
                    }
                }
                BinData("", "", "");
                MessageBox.Show("Successful delete " + count + " item.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                int row = e.RowIndex;
                txtClassID.Text = dgvClass.Rows[row].Cells[0].Value.ToString();
                txtClassName.Text = dgvClass.Rows[row].Cells[1].Value.ToString();
                cmbFacultyID.SelectedValue = dgvClass.Rows[row].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows[0].Index < 0) return;
            try
            {
                int row = dgvClass.SelectedRows[0].Index;
                txtClassID.Text = dgvClass.Rows[row].Cells[0].Value.ToString();
                txtClassName.Text = dgvClass.Rows[row].Cells[1].Value.ToString();
                cmbFacultyID.SelectedValue = dgvClass.Rows[row].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (dgvClass.SelectedRows[0].Index < 0) return;
            if (MessageBox.Show("Delete this teacher ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (obj.Class_Delete(dgvClass.SelectedRows[0].Cells["id"].Value.ToString()))
                {
                    MessageBox.Show("Delete teacher successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BinData("", "", "");
                }
                else
                {
                    MessageBox.Show("Delete teacher unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvClass_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvClass.ClearSelection();
                    dgvClass.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtSearch.Text);
                BinData("", " id = '" + x + "' or className like N'%" + x + "%'", "");
            }
            catch
            {
                BinData("", " className like N'%" + txtSearch.Text + "%'", "");
            }
        }
    }
}
