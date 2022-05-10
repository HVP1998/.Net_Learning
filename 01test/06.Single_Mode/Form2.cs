using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06.Single_Mode
{
    public partial class Form2 : Form
    {
        private static Form2 _f2=null;
        private Form2()
        {
            InitializeComponent();
        }
        public static Form2 GetSingleForm2()
        {
            if(_f2==null)
            {
                _f2 = new Form2();
            }
            return _f2;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _f2 = null;
        }

        private void ButOpenForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = Form3.GetSingleForm3();
            form3.Show();
        }
    }
}
