
namespace _13.窗口传值
{
    partial class Form1
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
            this.ButOpenForm2 = new System.Windows.Forms.Button();
            this.LabText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButOpenForm2
            // 
            this.ButOpenForm2.Location = new System.Drawing.Point(517, 240);
            this.ButOpenForm2.Name = "ButOpenForm2";
            this.ButOpenForm2.Size = new System.Drawing.Size(75, 23);
            this.ButOpenForm2.TabIndex = 0;
            this.ButOpenForm2.Text = "Open Form2";
            this.ButOpenForm2.UseVisualStyleBackColor = true;
            this.ButOpenForm2.Click += new System.EventHandler(this.ButOpenForm2_Click);
            // 
            // LabText
            // 
            this.LabText.AutoSize = true;
            this.LabText.Location = new System.Drawing.Point(196, 245);
            this.LabText.Name = "LabText";
            this.LabText.Size = new System.Drawing.Size(41, 12);
            this.LabText.TabIndex = 1;
            this.LabText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabText);
            this.Controls.Add(this.ButOpenForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButOpenForm2;
        private System.Windows.Forms.Label LabText;
    }
}

