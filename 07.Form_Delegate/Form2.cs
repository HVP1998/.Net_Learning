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
    public partial class Form2 : Form
    {
        public delegate void DelSendValue(string str);
        private static DelSendValue delSendValue;
        private static Form2 _f2=null;
        private Form2()
        {
            InitializeComponent();
        }
        public static Form2 GetSingleForm2(DelSendValue del)
        {
            delSendValue = del;
            if(_f2==null)
            {
                _f2 = new Form2();
            }
            return _f2;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _f2 = null;
            delSendValue( "***************");
        }

        private void ButOpenForm2_Click(object sender, EventArgs e)
        {
            delSendValue(textBox1.Text);
        }
    }
}
