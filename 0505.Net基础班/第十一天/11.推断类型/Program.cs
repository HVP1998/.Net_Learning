using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.推断类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //推断类型必须付初值
            var n1 = "qwe";
            var n2 = 123;
            var n3 = 'n';
            var n4 = true;
            var n5 = 45.6;


            object[] n_array = { n1, n2, n3, n4,n5 };

            foreach (var item in n_array)
            {
                Console.WriteLine(item.GetType());
            }
            Console.ReadKey();

        }
    }
}
