using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.File类
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Create(@"C:\Users\ASUS\Desktop\3.txt");
            Console.WriteLine("创建成功");
            File.Copy(@"C:\Users\ASUS\Desktop\1.txt", @"C:\Users\ASUS\Desktop\2.txt");
            Console.WriteLine("复制成功");
            File.Delete(@"C:\Users\ASUS\Desktop\1.txt");
            Console.WriteLine("删除成功");
            Console.ReadKey();
        }
    }
}
