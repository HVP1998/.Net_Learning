using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class LoginFailureForm : Form
    {
        public LoginFailureForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化窗口
        /// 1.定位窗口在屏幕居中
        /// 2.加载图片
        /// 3.加载文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginFailureForm_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            this.Location = (Point)new Size(x, y);         //窗体的起始位置为(x,y)
            ImagBox.Image = Image.FromFile(@"1.jpg");
            LabFailure.Text = "Username or Password is not correct.";
        }
        /// <summary>
        /// 点击OK按钮
        /// 1.释放资源
        /// 2.关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
