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

namespace GUI
{
    public partial class FormMain : Form
    {

        private static bool isClose = false;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
                if(MessageBox.Show("Exit application?","Confirm Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    isClose = true;
                }else
                {
                    isClose = false;
                }
            Exit(isClose);
          
        }

        private void Exit(bool b)
        {
            if (b)
            {
                Application.Exit();
                new FormLogin().Show();
            }
        }

        private void btnScroll_Click(object sender, EventArgs e)
        {
            if (slideMenu.Width == 226)
            {
                //minimize
                slideMenu.Width = 41;
            }
            else
            {
                slideMenu.Width = 226;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbUserName.Text = Common.UserName;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormQuiz().Show();
        }

        private void btnQues_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormQuestion().Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            new FormTeacher().Show();
            this.Hide();
          
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormSubject().Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormImport().Show();
        }
    }
}
