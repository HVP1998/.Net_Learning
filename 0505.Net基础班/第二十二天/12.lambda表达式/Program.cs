using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.lambda表达式
{
    public delegate void Del1();
    public delegate void Del2(string str);
    public delegate string Del3(string str);
    class Program
    {
        static void Main(string[] args)
        {
            Del1 d1 = () => { };
            Del2 d2 = (string str) => { };
            Del3 d3 = (string str) => { return str; };
            Console.ReadKey();
        }
    }
}
