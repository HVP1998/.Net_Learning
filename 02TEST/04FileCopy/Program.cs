using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FileCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\ASUS\Desktop\新建文件夹\1.mp4";
            string target = @"C:\Users\ASUS\Desktop\新建文件夹\2.mp4";
            if (!File.Exists(target))
            {
                FileCopy(source, target);
            }
            else
                Console.WriteLine("File exists");
            Console.ReadKey();
        }
        public static void FileCopy(string source, string target)
        {
            using (FileStream fsread = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fswrite = new FileStream(target, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[5 * 1024 * 1024];
                    int len = fsread.Read(buffer, 0, buffer.Length);
                    if (len == 0)
                    {
                        return;
                    }
                    fswrite.Write(buffer, 0, len);
                }
            }
            Console.WriteLine("Copy Complete");
        }
    }
}
