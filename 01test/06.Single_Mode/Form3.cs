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
    public partial class Form3 : Form
    {
        private static Form3 _f3 = null;
        private Form3()
        {
            InitializeComponent();
        }
        public static Form3 GetSingleForm3()
        {
            if(_f3==null)
            {
                _f3 = new Form3();
            }
            return _f3;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            _f3 = null;
        }

        private void ButCloseAll_Click(object sender, EventArgs e)
        {
            F1.FORM1.Close();
        }
    }
}
