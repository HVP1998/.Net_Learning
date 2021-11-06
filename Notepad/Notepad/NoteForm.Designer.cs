
namespace Notepad
{
    partial class NoteForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动换行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.固定记录列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtWord = new System.Windows.Forms.TextBox();
            this.ListBoxRecord = new System.Windows.Forms.ListBox();
            this.GBRecord = new System.Windows.Forms.GroupBox();
            this.ButFlod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.GBRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.打开ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体ToolStripMenuItem,
            this.颜色ToolStripMenuItem,
            this.自动换行ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.字体ToolStripMenuItem.Text = "字体";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 自动换行ToolStripMenuItem
            // 
            this.自动换行ToolStripMenuItem.Name = "自动换行ToolStripMenuItem";
            this.自动换行ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.自动换行ToolStripMenuItem.Text = "自动换行";
            this.自动换行ToolStripMenuItem.Click += new System.EventHandler(this.自动换行ToolStripMenuItem_Click);
            // 
            // 记录ToolStripMenuItem
            // 
            this.记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem1,
            this.隐藏ToolStripMenuItem,
            this.固定记录列表ToolStripMenuItem});
            this.记录ToolStripMenuItem.Name = "记录ToolStripMenuItem";
            this.记录ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.记录ToolStripMenuItem.Text = "记录";
            // 
            // 打开ToolStripMenuItem1
            // 
            this.打开ToolStripMenuItem1.Name = "打开ToolStripMenuItem1";
            this.打开ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem1.Text = "打开";
            this.打开ToolStripMenuItem1.Click += new System.EventHandler(this.打开ToolStripMenuItem1_Click);
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            this.隐藏ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.隐藏ToolStripMenuItem.Text = "隐藏";
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.隐藏ToolStripMenuItem_Click);
            // 
            // 固定记录列表ToolStripMenuItem
            // 
            this.固定记录列表ToolStripMenuItem.Name = "固定记录列表ToolStripMenuItem";
            this.固定记录列表ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.固定记录列表ToolStripMenuItem.Text = "清空";
            this.固定记录列表ToolStripMenuItem.Click += new System.EventHandler(this.固定记录列表ToolStripMenuItem_Click);
            // 
            // TxtWord
            // 
            this.TxtWord.Location = new System.Drawing.Point(160, 28);
            this.TxtWord.Multiline = true;
            this.TxtWord.Name = "TxtWord";
            this.TxtWord.Size = new System.Drawing.Size(628, 248);
            this.TxtWord.TabIndex = 1;
            this.TxtWord.FontChanged += new System.EventHandler(this.TxtWord_FontChanged);
            this.TxtWord.ForeColorChanged += new System.EventHandler(this.TxtWord_ForeColorChanged);
            this.TxtWord.TextChanged += new System.EventHandler(this.TxtWord_TextChanged);
            // 
            // ListBoxRecord
            // 
            this.ListBoxRecord.FormattingEnabled = true;
            this.ListBoxRecord.ItemHeight = 12;
            this.ListBoxRecord.Location = new System.Drawing.Point(12, 20);
            this.ListBoxRecord.Name = "ListBoxRecord";
            this.ListBoxRecord.Size = new System.Drawing.Size(120, 208);
            this.ListBoxRecord.TabIndex = 2;
            this.ListBoxRecord.SelectedIndexChanged += new System.EventHandler(this.ListBoxRecord_SelectedIndexChanged);
            // 
            // GBRecord
            // 
            this.GBRecord.Controls.Add(this.ButFlod);
            this.GBRecord.Controls.Add(this.ListBoxRecord);
            this.GBRecord.Location = new System.Drawing.Point(0, 28);
            this.GBRecord.Name = "GBRecord";
            this.GBRecord.Size = new System.Drawing.Size(154, 248);
            this.GBRecord.TabIndex = 3;
            this.GBRecord.TabStop = false;
            // 
            // ButFlod
            // 
            this.ButFlod.Location = new System.Drawing.Point(134, 85);
            this.ButFlod.Name = "ButFlod";
            this.ButFlod.Size = new System.Drawing.Size(14, 71);
            this.ButFlod.TabIndex = 4;
            this.ButFlod.Text = "《";
            this.ButFlod.UseVisualStyleBackColor = true;
            this.ButFlod.Click += new System.EventHandler(this.ButFlod_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.GBRecord);
            this.Controls.Add(this.TxtWord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NoteForm";
            this.Text = "NOTEPAD";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBRecord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动换行ToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtWord;
        private System.Windows.Forms.ToolStripMenuItem 记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 固定记录列表ToolStripMenuItem;
        private System.Windows.Forms.ListBox ListBoxRecord;
        private System.Windows.Forms.GroupBox GBRecord;
        private System.Windows.Forms.Button ButFlod;
    }
}