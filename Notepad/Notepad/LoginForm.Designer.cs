
namespace Notepad
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LabUserName = new System.Windows.Forms.Label();
            this.LabPassword = new System.Windows.Forms.Label();
            this.TxtboxUsername = new System.Windows.Forms.TextBox();
            this.TxtboxPassword = new System.Windows.Forms.TextBox();
            this.RadButTeacher = new System.Windows.Forms.RadioButton();
            this.RadButStudent = new System.Windows.Forms.RadioButton();
            this.ButReset = new System.Windows.Forms.Button();
            this.ButLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabUserName
            // 
            this.LabUserName.AutoSize = true;
            this.LabUserName.Location = new System.Drawing.Point(76, 42);
            this.LabUserName.Name = "LabUserName";
            this.LabUserName.Size = new System.Drawing.Size(59, 12);
            this.LabUserName.TabIndex = 0;
            this.LabUserName.Text = "Username:";
            // 
            // LabPassword
            // 
            this.LabPassword.AutoSize = true;
            this.LabPassword.Location = new System.Drawing.Point(76, 74);
            this.LabPassword.Name = "LabPassword";
            this.LabPassword.Size = new System.Drawing.Size(59, 12);
            this.LabPassword.TabIndex = 1;
            this.LabPassword.Text = "Password:";
            // 
            // TxtboxUsername
            // 
            this.TxtboxUsername.Location = new System.Drawing.Point(138, 39);
            this.TxtboxUsername.Name = "TxtboxUsername";
            this.TxtboxUsername.Size = new System.Drawing.Size(186, 21);
            this.TxtboxUsername.TabIndex = 2;
            // 
            // TxtboxPassword
            // 
            this.TxtboxPassword.Location = new System.Drawing.Point(138, 71);
            this.TxtboxPassword.Name = "TxtboxPassword";
            this.TxtboxPassword.PasswordChar = '*';
            this.TxtboxPassword.Size = new System.Drawing.Size(186, 21);
            this.TxtboxPassword.TabIndex = 3;
            // 
            // RadButTeacher
            // 
            this.RadButTeacher.AutoSize = true;
            this.RadButTeacher.Location = new System.Drawing.Point(97, 107);
            this.RadButTeacher.Name = "RadButTeacher";
            this.RadButTeacher.Size = new System.Drawing.Size(65, 16);
            this.RadButTeacher.TabIndex = 4;
            this.RadButTeacher.Text = "Teacher";
            this.RadButTeacher.UseVisualStyleBackColor = true;
            this.RadButTeacher.CheckedChanged += new System.EventHandler(this.RadButTeacher_CheckedChanged);
            // 
            // RadButStudent
            // 
            this.RadButStudent.AutoSize = true;
            this.RadButStudent.Location = new System.Drawing.Point(219, 107);
            this.RadButStudent.Name = "RadButStudent";
            this.RadButStudent.Size = new System.Drawing.Size(65, 16);
            this.RadButStudent.TabIndex = 5;
            this.RadButStudent.Text = "Student";
            this.RadButStudent.UseVisualStyleBackColor = true;
            this.RadButStudent.CheckedChanged += new System.EventHandler(this.RadButStudent_CheckedChanged);
            // 
            // ButReset
            // 
            this.ButReset.Location = new System.Drawing.Point(78, 139);
            this.ButReset.Name = "ButReset";
            this.ButReset.Size = new System.Drawing.Size(75, 23);
            this.ButReset.TabIndex = 6;
            this.ButReset.Text = "Reset";
            this.ButReset.UseVisualStyleBackColor = true;
            this.ButReset.Click += new System.EventHandler(this.ButReset_Click);
            // 
            // ButLogin
            // 
            this.ButLogin.Location = new System.Drawing.Point(249, 139);
            this.ButLogin.Name = "ButLogin";
            this.ButLogin.Size = new System.Drawing.Size(75, 23);
            this.ButLogin.TabIndex = 7;
            this.ButLogin.Text = "Login";
            this.ButLogin.UseVisualStyleBackColor = true;
            this.ButLogin.Click += new System.EventHandler(this.ButLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 204);
            this.Controls.Add(this.ButLogin);
            this.Controls.Add(this.ButReset);
            this.Controls.Add(this.RadButStudent);
            this.Controls.Add(this.RadButTeacher);
            this.Controls.Add(this.TxtboxPassword);
            this.Controls.Add(this.TxtboxUsername);
            this.Controls.Add(this.LabPassword);
            this.Controls.Add(this.LabUserName);
            this.Name = "LoginForm";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabUserName;
        private System.Windows.Forms.Label LabPassword;
        private System.Windows.Forms.TextBox TxtboxUsername;
        private System.Windows.Forms.TextBox TxtboxPassword;
        private System.Windows.Forms.RadioButton RadButTeacher;
        private System.Windows.Forms.RadioButton RadButStudent;
        private System.Windows.Forms.Button ButReset;
        private System.Windows.Forms.Button ButLogin;
    }
}

