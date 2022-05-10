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
    public partial class Form3 : Form
    {
        private static Form3 form3 = null;
        private Form3()
        {
            InitializeComponent();
        }
        public static Form3 CreateSingleForm3()
        {
            if (form3 == null)
                form3 = new Form3();
            return form3;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form3 = null;
        }

        private void ButCloseAll_Click(object sender, EventArgs e)
        {
            test.Form.Close();
        }
    }
}
