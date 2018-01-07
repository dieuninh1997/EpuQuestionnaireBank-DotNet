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

namespace GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }
        private bool LoginValid(String u, String p)
        {
            TeacherBUS obj = new TeacherBUS();
            if (obj.Teacher_LoginValid(u, p))
            {
                MessageBox.Show("Login successful!");
                return true;
            }
            else
            {
                MessageBox.Show("Login unsuccessful!");
                Clear();
                return false;
            }
        }
        private bool ValidField()
        {
            return (txtUserName.Text.Equals("") || txtPassword.Text.Equals("")) ? true : false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                MessageBox.Show("Please fill user name and password!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Select();
                return;
            }
            if (LoginValid(txtUserName.Text, txtPassword.Text))
            {
                new FormMain().Show();
                this.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
