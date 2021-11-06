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
    public partial class LoginForm : Form
    {
        private string _username;
        private string _password;
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化登录窗口：
        /// 1.窗口在屏幕居中
        /// 2.将焦点设置在用户名输入窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {

            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            this.Location = (Point)new Size(x, y);         //窗体的起始位置为(x,y)
            TxtboxUsername.Focus();
        }
        /// <summary>
        /// 点击重置：
        /// 1.按钮将用户名、密码清空
        /// 2.取消身份选中
        /// 3.将焦点设置在用户名输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButReset_Click(object sender, EventArgs e)
        {
            TxtboxUsername.Text = "";
            TxtboxPassword.Text = "";
            RadButStudent.Checked = false;
            RadButTeacher.Checked = false;
            TxtboxUsername.Focus();
        }
        /// <summary>
        /// 点击登录按钮：
        /// 1.如果用户名或密码为空，提醒
        /// 2.如果身份没有选中，提醒
        /// 3.如果用户名或密码错误，提醒
        /// 4.如果用户名密码正确则显示登录成功，打开记事本关闭登录界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButLogin_Click(object sender, EventArgs e)
        {
            if((TxtboxUsername.Text=="")||(TxtboxPassword.Text==""))
            {
                MessageBox.Show("Usernam or Password is empty");
            }
            else if((RadButStudent.Checked==false)&&(RadButTeacher.Checked==false))
            {
                MessageBox.Show("Identification is not be chosen.");
            }
            else if((TxtboxUsername.Text==_username)&&(TxtboxPassword.Text==_password))
            {
                LoginSucceeForm loginSucceeForm = new LoginSucceeForm();
                loginSucceeForm.ShowDialog();

                this.Dispose();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                LoginFailureForm loginFailureForm = new LoginFailureForm();
                loginFailureForm.ShowDialog();
            }
        }
        /// <summary>
        /// 如果身份被选中则用户名与密码确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadButTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (RadButTeacher.Checked == true)
            {
                _username = "teacher";
                _password = "teacher";
            }
            else if (RadButStudent.Checked == true)
            {
                _username = "student";
                _password = "student";
            }
            else
            {
                _username = "";
                _password = "";
            }
        }
        /// <summary>
        /// 如果身份被选中则用户名与密码确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadButStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (RadButTeacher.Checked == true)
            {
                _username = "teacher";
                _password = "teacher";
            }
            else if (RadButStudent.Checked == true)
            {
                _username = "student";
                _password = "student";
            }
            else
            {
                _username = "";
                _password = "";
            }
        }
    }
}
