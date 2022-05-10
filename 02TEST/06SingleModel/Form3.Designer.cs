
namespace _06SingleModel
{
    partial class Form3
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
            this.ButCloseAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButCloseAll
            // 
            this.ButCloseAll.Location = new System.Drawing.Point(295, 199);
            this.ButCloseAll.Name = "ButCloseAll";
            this.ButCloseAll.Size = new System.Drawing.Size(211, 53);
            this.ButCloseAll.TabIndex = 1;
            this.ButCloseAll.Text = "Close All";
            this.ButCloseAll.UseVisualStyleBackColor = true;
            this.ButCloseAll.Click += new System.EventHandler(this.ButCloseAll_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButCloseAll);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButCloseAll;
    }
}