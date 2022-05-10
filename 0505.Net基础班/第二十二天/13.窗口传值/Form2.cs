using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.窗口传值
{
    public delegate void DelSendValue(string str);
    public partial class Form2 : Form
    {
        private static Form2 _f2 = null;
        private static DelSendValue _del;
        private Form2()
        {
            InitializeComponent();
        }

        public static Form2 GetSingleForm2(DelSendValue del)
        {
            _del = del;
            if(_f2==null)
            {
                _f2 = new Form2();
            }
            return _f2;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _f2 = null;
            _del("***************");
        }

        private void ButSendValue_Click(object sender, EventArgs e)
        {
            _del(TxtBox.Text);
        }
    }
}
