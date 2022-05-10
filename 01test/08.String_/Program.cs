using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.String_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="12sdfs-5444,sdfs";
            char[] c = { '-', ',' };
            string[] str_array = str.Split(c);
            foreach (var item in str_array)
            {
                Console.WriteLine(item);
            }
            string str1 = " 1 22 5555555   ";
            string str1_trimstart= str1.TrimStart();
            Console.WriteLine(str1_trimstart);
            string str1_trimend = str1.TrimEnd();
            Console.Write(str1_trimend);
            string str1_trim = str1.Trim();
            Console.Write(str1_trim);
            Console.WriteLine(str.Length);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Contains("s"));
            Console.WriteLine(str.StartsWith("s"));
            Console.WriteLine(str.EndsWith("s"));
            Console.WriteLine(str.Substring(0, 3));
            Console.WriteLine(string.Join("", str_array));
            Console.WriteLine(str.IndexOf('s'));
            Console.WriteLine(str.LastIndexOf('s'));
            string[] str2 = new string[3];
            foreach (var item in str2)
            {
                Console.WriteLine(item);
            }
            double[] nums = new double[3];
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
