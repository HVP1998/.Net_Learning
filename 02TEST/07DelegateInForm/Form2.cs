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
    public delegate void DelSendValue(string str);
    public partial class Form2 : Form
    {
        private static Form2 f2 = null;
        public static DelSendValue delSendValue;
        private Form2()
        {
            InitializeComponent();
        }

        public static Form2 GetSingleForm(DelSendValue del)
        {
            delSendValue = del;
            if (f2 == null)
                f2 = new Form2();
            return f2;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
            delSendValue("******************");
        }

        private void ButSendValue_Click(object sender, EventArgs e)
        {
            delSendValue(TxtBox.Text);
        }
    }
}
