using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new LoginForm());

            LoginForm logform = new LoginForm();

            logform.ShowDialog();

            if (logform.DialogResult == DialogResult.OK)
            {
                logform.Dispose();
                Application.Run(new NoteForm());
            }
            else
            {
                logform.Dispose();
                return;
            }
        }
    }
}
