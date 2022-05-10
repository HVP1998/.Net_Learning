using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class NoteForm : Form
    {
        //标记是否打开文件
        private bool _openFile;
        //文本框的大小
        private Size s = new Size();
        //文本框的坐标
        private Point p = new Point();
        //存放文件路径的列表
        private List<string> _fileList = new List<string>();
        //当前文件路径
        private string _filePath = "";
        public NoteForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化窗口
        /// 1.标记文件打开、自动换行为假
        /// 2.隐藏记录表
        /// 3.设置文本框大小与位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteForm_Load(object sender, EventArgs e)
        {
            //打开文件标记为假
            _openFile = false;
            //取消自动换行
            TxtWord.WordWrap = false;
            //隐藏记录表
            GBRecord.Visible = false;
            ChangeTxtWord(GBRecord.Visible);
        }



        /// <summary>
        /// 单机列表中的文件名则可以在文本框中写入相关文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filePath = _fileList[ListBoxRecord.SelectedIndex];
            FileRead(_filePath);
        }


        /// <summary>
        /// 点击折叠按钮
        /// 1.折叠记录表
        /// 2.恢复文本框位置与大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButFlod_Click(object sender, EventArgs e)
        {
            GBRecord.Visible = false;
            ChangeTxtWord(GBRecord.Visible);
        }



        /// <summary>
        /// 点击菜单中的文件——保存
        /// 1.如果没有打开文件的记录（_openFile==false）则保存一个新的文件
        /// 2.如果有打开文件的记录（_openFile==true）则保存到当前的文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_openFile == false)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "保存文件";
                sfd.InitialDirectory = @"C:\Users\ASUS\Desktop\新建文件夹";
                sfd.Filter = "文本类型|*.txt|所有类型|*.*";
                sfd.ShowDialog();
                if (sfd.FileName != "")
                {
                    FileWrite(sfd.FileName);
                    this.Text = this.Text.Substring(0, this.Text.Length - 1);
                }

            }
            else
            {
                FileWrite(_filePath);
                this.Text = this.Text.Substring(0, this.Text.Length - 1);
            }
        }
        /// <summary>
        /// 点击菜单栏中的文件——另存为
        /// 将文本框中的文本保存到另一个文件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "保存文件";
            sfd.InitialDirectory = @"C:\Users\ASUS\Desktop\新建文件夹";
            sfd.Filter = "文本类型|*.txt|所有类型|*.*";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                FileWrite(sfd.FileName);
                this.Text = this.Text.Substring(0, this.Text.Length - 1);
            }

        }
        /// <summary>
        /// 点击菜单栏中的文件——打开
        /// 打开一个文件将其中的文本写入字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\ASUS\Desktop\新建文件夹";
            ofd.Title = "打开文件";
            ofd.Multiselect = false;
            ofd.Filter = "文本类型|*.txt|其他类型|*.*";
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                _openFile = true;
                _fileList.Add(ofd.FileName);
                _filePath = ofd.FileName;
                ListBoxRecord.Items.Add(Path.GetFileNameWithoutExtension(ofd.FileName));
                FileRead(ofd.FileName);
            }

        }



        /// <summary>
        /// 点击菜单栏中的记录——打开
        /// 1.打开记录表
        /// 2.改变文本框位置与大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (GBRecord.Visible == true)
                return;
            GBRecord.Visible = true;
            ChangeTxtWord(GBRecord.Visible);
        }
        /// <summary>
        /// 点击菜单栏中的记录——隐藏
        /// 1.隐藏记录表
        /// 2.改变文本框位置与大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GBRecord.Visible == false)
                return;
            GBRecord.Visible = false;
            ChangeTxtWord(GBRecord.Visible);
        }
        /// <summary>
        /// 点击菜单栏中的记录——清空
        /// 清空列表中所有的记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 固定记录列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBoxRecord.Items.Clear();
        }



        /// <summary>
        /// 点击菜单栏中的编辑——字体
        /// 改变文本框中的字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            TxtWord.Font = fd.Font;

        }
        /// <summary>
        /// 点击菜单栏中的编辑——颜色
        /// 改变文本框中的颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            TxtWord.ForeColor = colorDialog.Color;
        }
        /// <summary>
        /// 点击菜单栏中的编辑——自动换行
        /// 改变文本框中的自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtWord.WordWrap == true)
            {
                TxtWord.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "自动换行";
            }
            else
            {
                TxtWord.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "自动换行√";
            }
        }



        /// <summary>
        /// 当文本框内内容改变时给文件名加*
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtWord_TextChanged(object sender, EventArgs e)
        {
            if (_filePath != "")
            {
                if (Path.GetFileNameWithoutExtension(_filePath).Substring(Path.GetFileNameWithoutExtension(_filePath).Length - 1, 1) == "*")
                    return;
                this.Text = Path.GetFileNameWithoutExtension(_filePath) + "*";
            }
            else
            {
                if (this.Text.Substring(this.Text.Length - 1, 1) == "*")
                    return;
                this.Text = this.Text + "*";
            }

        }
        /// <summary>
        /// 当文本框内字体改变时给文件名加*
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtWord_FontChanged(object sender, EventArgs e)
        {
            if (_filePath != "")
            {
                if (Path.GetFileNameWithoutExtension(_filePath).Substring(Path.GetFileNameWithoutExtension(_filePath).Length - 1, 1) == "*")
                    return;
                this.Text = Path.GetFileNameWithoutExtension(_filePath) + "*";
            }
            else
            {
                if (this.Text.Substring(this.Text.Length - 1, 1) == "*")
                    return;
                this.Text = this.Text + "*";
            }
        }
        /// <summary>
        /// 当文本框内颜色改变时给文件名加*
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtWord_ForeColorChanged(object sender, EventArgs e)
        {
            if (_filePath != "")
            {
                if (Path.GetFileNameWithoutExtension(_filePath).Substring(Path.GetFileNameWithoutExtension(_filePath).Length - 1, 1) == "*")
                    return;
                this.Text = Path.GetFileNameWithoutExtension(_filePath) + "*";
            }
            else
            {
                if (this.Text.Substring(this.Text.Length - 1, 1) == "*")
                    return;
                this.Text = this.Text + "*";
            }
        }



        /// <summary>
        /// 根据记录表显示与否调节文本框
        /// </summary>
        /// <param name="judge">记录表是否显示</param>
        private void ChangeTxtWord(bool judge)
        {
            if (GBRecord.Visible == false)
            {
                s.Width = 776;
                s.Height = 248;
                TxtWord.Size = s;
                p.X = 12;
                p.Y = 28;
                TxtWord.Location = p;
            }
            else
            {
                s.Width = 628;
                s.Height = 248;
                TxtWord.Size = s;
                p.X = 160;
                p.Y = 28;
                TxtWord.Location = p;
            }
        }
        /// <summary>
        /// 读取文件中的字符写入文本框
        /// </summary>
        /// <param name="filePath">读取文件路径</param>
        private void FileRead(string filePath)
        {
            using (FileStream fsread = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int length;
                TxtWord.Text = "";
                byte[] buffer = new byte[5 * 1024 * 1024];
                while (true)
                {
                    length = fsread.Read(buffer, 0, buffer.Length);
                    TxtWord.Text = TxtWord.Text + Encoding.UTF8.GetString(buffer);
                    if (length == 0)
                        break;
                }
            }
        }
        /// <summary>
        /// 读取文本框中的字符写入文件中
        /// </summary>
        /// <param name="filePath">写入文件路径</param>
        private void FileWrite(string filePath)
        {
            using (FileStream fswrite = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(TxtWord.Text);
                fswrite.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
