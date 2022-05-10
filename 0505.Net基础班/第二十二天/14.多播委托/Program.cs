using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.多播委托
{
    public delegate void Del();
    class Program
    {
        static void Main(string[] args)
        {
            Del d = Test1;
            d =d+ Test2+Test3+Test4;
            A_Test(d);
            d = d - Test2 - Test4;
            A_Test(d);
            d = Test4;
            A_Test(d);
            Console.ReadKey();

        }
        public static void A_Test(Del d)
        {
            d();
        }
        public static void Test1()
        {
            Console.WriteLine("test1");
        }
        public static void Test2()
        {
            Console.WriteLine("test2");
        }
        public static void Test3()
        {
            Console.WriteLine("test3");
        }
        public static void Test4()
        {
            Console.WriteLine("test4");
        }
    }


}
