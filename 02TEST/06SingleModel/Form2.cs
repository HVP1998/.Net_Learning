using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06SingleModel
{
    public partial class Form2 : Form
    {
        private static Form2 form2 = null;
        private Form2()
        {
            InitializeComponent();
        }
        public static Form2 CreateSingleForm2()
        {
            if (form2 == null)
                form2 = new Form2();
            return form2;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2 = null;
        }

        private void ButOpenForm3_Click(object sender, EventArgs e)
        {
            Form3 f3 = Form3.CreateSingleForm3();
            f3.Show();
        }
    }
}
