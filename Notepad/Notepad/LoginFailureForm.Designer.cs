
namespace Notepad
{
    partial class LoginFailureForm
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
            this.ImagBox = new System.Windows.Forms.PictureBox();
            this.LabFailure = new System.Windows.Forms.Label();
            this.ButOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagBox
            // 
            this.ImagBox.Location = new System.Drawing.Point(45, 39);
            this.ImagBox.Name = "ImagBox";
            this.ImagBox.Size = new System.Drawing.Size(59, 58);
            this.ImagBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagBox.TabIndex = 0;
            this.ImagBox.TabStop = false;
            // 
            // LabFailure
            // 
            this.LabFailure.AutoSize = true;
            this.LabFailure.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabFailure.Location = new System.Drawing.Point(162, 51);
            this.LabFailure.Name = "LabFailure";
            this.LabFailure.Size = new System.Drawing.Size(56, 16);
            this.LabFailure.TabIndex = 1;
            this.LabFailure.Text = "label1";
            // 
            // ButOK
            // 
            this.ButOK.Location = new System.Drawing.Point(234, 114);
            this.ButOK.Name = "ButOK";
            this.ButOK.Size = new System.Drawing.Size(117, 23);
            this.ButOK.TabIndex = 2;
            this.ButOK.Text = "OK";
            this.ButOK.UseVisualStyleBackColor = true;
            this.ButOK.Click += new System.EventHandler(this.ButOK_Click);
            // 
            // LoginFailureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 167);
            this.Controls.Add(this.ButOK);
            this.Controls.Add(this.LabFailure);
            this.Controls.Add(this.ImagBox);
            this.Name = "LoginFailureForm";
            this.Text = "LoginFailureForm";
            this.Load += new System.EventHandler(this.LoginFailureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagBox;
        private System.Windows.Forms.Label LabFailure;
        private System.Windows.Forms.Button ButOK;
    }
}