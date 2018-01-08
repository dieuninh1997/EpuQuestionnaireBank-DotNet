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
    public partial class FormViewExam : Form
    {
        public FormViewExam()
        {
            InitializeComponent();
        }
        public FormViewExam(string view)
        {
            InitializeComponent();
            txtView.Text = view;
        }
        private void FormViewExam_Load(object sender, EventArgs e)
        {

        }
    }
}
