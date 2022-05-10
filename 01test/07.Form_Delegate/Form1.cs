using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07.Form_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = Form2.GetSingleForm2(ShowText);
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabText.Text = "***************";
        }
        public void ShowText(string str)
        {
            LabText.Text = str;
        }
    }
}
