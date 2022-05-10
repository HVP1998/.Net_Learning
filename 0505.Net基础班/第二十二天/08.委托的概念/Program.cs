using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.委托的概念
{
    public delegate void DelSayHi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "马邦德";
            SayHi(name1, SayHiChinese);
            string name2 = "James Bond";
            SayHi(name2, SayHiEnglish);
            Console.ReadKey();

        }

        public static void SayHi(string name,DelSayHi del)
        {
            del(name);
        }

        public static void SayHiChinese(string name)
        {
            Console.WriteLine("{0}吃了吗？", name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to meet you,{0}.", name);
        }
    }
}
