
namespace _06.Single_Mode
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
            this.ButOpenForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButOpenForm3
            // 
            this.ButOpenForm3.Location = new System.Drawing.Point(363, 214);
            this.ButOpenForm3.Name = "ButOpenForm3";
            this.ButOpenForm3.Size = new System.Drawing.Size(75, 23);
            this.ButOpenForm3.TabIndex = 1;
            this.ButOpenForm3.Text = "Open Form3";
            this.ButOpenForm3.UseVisualStyleBackColor = true;
            this.ButOpenForm3.Click += new System.EventHandler(this.ButOpenForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButOpenForm3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButOpenForm3;
    }
}