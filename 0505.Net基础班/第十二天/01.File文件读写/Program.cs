using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.File文件读写
{
    class Program
    {
        static void Main(string[] args)
        {
            //UTF-8 GBK GB2312 ASCII Unicode
            string s=@"醉花阴
                             [宋]李清照";
            byte[] buffer= Encoding.GetEncoding("UTF-8").GetBytes(s);
            string s1=File.ReadAllText(@"C:\Users\ASUS\Desktop\1.txt",Encoding.UTF8);
            string[] s1_array=File.ReadAllLines(@"C:\Users\ASUS\Desktop\1.txt", Encoding.UTF8);
            Console.WriteLine(s1);
            foreach (var item in s1_array)
            {
                Console.WriteLine(item);
            }
            string[] s2_array = { "醉花阴", @"      [宋]李清照" };
            File.AppendAllLines(@"C:\Users\ASUS\Desktop\1.txt",s2_array );
            string s2 = File.ReadAllText(@"C:\Users\ASUS\Desktop\1.txt", Encoding.UTF8);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
