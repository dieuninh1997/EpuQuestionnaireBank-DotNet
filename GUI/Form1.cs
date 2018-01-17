using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        Home.ucHome _ucHome;
        Home.ucQuiz _ucQuiz;
        Home.ucReport _ucReport;
        Home.ucTools _ucTools;
        Home.ucHelp _ucHelp;
        public Form1()
        {
            InitializeComponent();
          //  menu_Home.Select();

             _ucHome = new Home.ucHome();
            _ucHelp = new Home.ucHelp();
            _ucQuiz = new Home.ucQuiz();
            _ucTools = new Home.ucTools();
            _ucReport = new Home.ucReport();

          //  container.Controls.Add(_ucHome);
            _ucHome.Show();
        }

     
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(slideMenu.Width>=257)
            {
                logo.Location = new Point(17, 63);
                logo.Size = new Size(35, 35);
                //
                slideMenu.Width = 72;
                nameProj.Visible = false;

            }else
            {
                logo.Location = new Point(90, 44);
                logo.Size = new Size(67, 67);
                //  
                slideMenu.Width = 257;
                nameProj.Visible = true;
            }
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Home_Click(object sender, EventArgs e)
        {
            _ucHome.BringToFront();
            _ucHome.Show();
        }

        private void menu_Quiz_Click(object sender, EventArgs e)
        {
          
            container.Controls.Add(_ucQuiz);
            _ucQuiz.BringToFront();
            _ucQuiz.Show();

        }

        private void menu_Tools_Click(object sender, EventArgs e)
        {
           
            container.Controls.Add(_ucTools);
            _ucTools.BringToFront();
            _ucTools.Show();
        }

        private void menu_Report_Click(object sender, EventArgs e)
        {
            
            container.Controls.Add(_ucReport);
            _ucReport.BringToFront();
            _ucReport.Show();

        }

        private void menu_Help_Click(object sender, EventArgs e)
        {
            
            container.Controls.Add(_ucHelp);
            _ucHelp.BringToFront();
            _ucHelp.Show();
        }

        private void ucHome1_Load(object sender, EventArgs e)
        {

        }
    }
}
