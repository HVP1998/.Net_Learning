using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07DelegateInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text= "******************";
        }
        public void ShowTxt(string str)
        {
            label2.Text = str;
        }

        private void ButOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = Form2.GetSingleForm(ShowTxt);
            f2.Show();
        }
    }
}
