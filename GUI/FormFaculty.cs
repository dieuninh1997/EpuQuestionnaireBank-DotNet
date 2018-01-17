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
    public partial class FormFaculty : Form
    {
        private FacultyBUS obj = new FacultyBUS();
    public FormFaculty()
        {
            InitializeComponent();
        }
        private void BindData(String t = "", String w = "", String o = "")
        {
            dgvFaculty.DataSource = obj.Faculty_GetByTop(t, w, o);
            dgvFaculty.Columns[0].HeaderText = "Mã khoa";
            dgvFaculty.Columns[1].HeaderText = "Tên khoa";
            dgvFaculty.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void Clear()
        {
            txtFacultyName.Text = "";
            txtFacultyID.Text = "";
            txtSearch.Text = "";
        }
        private bool ValidField()
        {
            return txtFacultyName.Text.Equals(String.Empty) ? true : false;
        }

        private void FormFaculty_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out textbox Faculty Name!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Faculty faculty = new Faculty(txtFacultyID.Text, txtFacultyName.Text);
            if (txtFacultyID.Text.Equals(""))
            {
                if (obj.Faculty_Insert(faculty))
                {
                    MessageBox.Show("Insert faculty successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insert faculty unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            BindData();
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill out textbox Faculty Name!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Faculty faculty = new Faculty(txtFacultyID.Text, txtFacultyName.Text);

            if (obj.Faculty_Update(faculty))
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
                foreach (DataGridViewRow r in dgvFaculty.SelectedRows)
                {
                    {
                        if (obj.Faculty_Delete(r.Cells["id"].Value.ToString())) { count++; }
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

        private void btnBack_Click(object sender, EventArgs e)
        { 
            new FormMain().Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtSearch.Text);
                BindData("", " id = '" + x + "' or facultyName like N'%" + x + "%'", "");
            }
            catch
            {
                BindData("", " facultyName like N'%" + txtSearch.Text + "%'", "");
            }
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFaculty.SelectedRows[0].Index < 0) return;
            try
            {
                int row = dgvFaculty.SelectedRows[0].Index;
                txtFacultyID.Text = dgvFaculty.Rows[row].Cells[0].Value.ToString();
                txtFacultyName.Text = dgvFaculty.Rows[row].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (dgvFaculty.SelectedRows[0].Index < 0) return;
            try
            {
                int row = dgvFaculty.SelectedRows[0].Index;
                txtFacultyID.Text = dgvFaculty.Rows[row].Cells[0].Value.ToString();
                txtFacultyName.Text = dgvFaculty.Rows[row].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {

            if (dgvFaculty.SelectedRows[0].Index < 0) return;
            try
            {
                if (MessageBox.Show("Delete this faculty ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (obj.Faculty_Delete(dgvFaculty.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Delete faculty successed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindData("", "", "");
                    }
                    else
                    {
                        MessageBox.Show("Delete faculty unsuccessed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Select a row first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvFaculty_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvFaculty.ClearSelection();
                    dgvFaculty.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void FormFaculty_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }
    }
    }
}
