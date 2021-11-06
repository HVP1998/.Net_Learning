
namespace Notepad
{
    partial class LoginSucceeForm
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
            this.ButOK = new System.Windows.Forms.Button();
            this.LabFailure = new System.Windows.Forms.Label();
            this.ImagBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ButOK
            // 
            this.ButOK.Location = new System.Drawing.Point(237, 119);
            this.ButOK.Name = "ButOK";
            this.ButOK.Size = new System.Drawing.Size(117, 23);
            this.ButOK.TabIndex = 5;
            this.ButOK.Text = "OK";
            this.ButOK.UseVisualStyleBackColor = true;
            this.ButOK.Click += new System.EventHandler(this.ButOK_Click);
            // 
            // LabFailure
            // 
            this.LabFailure.AutoSize = true;
            this.LabFailure.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabFailure.Location = new System.Drawing.Point(165, 56);
            this.LabFailure.Name = "LabFailure";
            this.LabFailure.Size = new System.Drawing.Size(56, 16);
            this.LabFailure.TabIndex = 4;
            this.LabFailure.Text = "label1";
            //this.LabFailure.Click += new System.EventHandler(this.LabFailure_Click);
            // 
            // ImagBox
            // 
            this.ImagBox.Location = new System.Drawing.Point(48, 44);
            this.ImagBox.Name = "ImagBox";
            this.ImagBox.Size = new System.Drawing.Size(59, 58);
            this.ImagBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagBox.TabIndex = 3;
            this.ImagBox.TabStop = false;
            //this.ImagBox.Click += new System.EventHandler(this.ImagBox_Click);
            // 
            // LoginSucceeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 167);
            this.Controls.Add(this.ButOK);
            this.Controls.Add(this.LabFailure);
            this.Controls.Add(this.ImagBox);
            this.Name = "LoginSucceeForm";
            this.Text = "LoginSucceeForm";
            this.Load += new System.EventHandler(this.LoginSucceeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButOK;
        private System.Windows.Forms.Label LabFailure;
        private System.Windows.Forms.PictureBox ImagBox;
    }
}