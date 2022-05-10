
namespace _07DelegateInForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButSendValue = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButSendValue
            // 
            this.ButSendValue.Location = new System.Drawing.Point(517, 219);
            this.ButSendValue.Name = "ButSendValue";
            this.ButSendValue.Size = new System.Drawing.Size(75, 23);
            this.ButSendValue.TabIndex = 0;
            this.ButSendValue.Text = "SendValue";
            this.ButSendValue.UseVisualStyleBackColor = true;
            this.ButSendValue.Click += new System.EventHandler(this.ButSendValue_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(132, 219);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(100, 21);
            this.TxtBox.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.ButSendValue);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButSendValue;
        private System.Windows.Forms.TextBox TxtBox;
    }
}