using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "123";
            Console.WriteLine(a.Substring(0, 2));
            Console.WriteLine("输入1结束程序");
            string b = Console.ReadLine();
            if (b != "1")
                return;
            Console.ReadKey();
        }
    }
}
