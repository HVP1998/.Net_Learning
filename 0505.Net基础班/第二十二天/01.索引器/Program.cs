using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("马邦德", GENDER.男, 23, 88, 95, 80);
            Console.WriteLine("Chinses grades:{0}", p["chinese"]);
            Console.ReadKey();
        }
    }
}
