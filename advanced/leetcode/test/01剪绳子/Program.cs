using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01剪绳子
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 4;
            Console.WriteLine(b |= 2);
            Console.WriteLine(4 & 2);
            Console.WriteLine(4 >> 1);
            Console.ReadKey();

        }
        /// <summary>
        /// 将一段长为n的绳子分为m段使这m段绳子长度之积最大
        /// </summary>
        /// <param name="n">绳子的长度</param>
        /// <returns>m段绳子乘积的结果</returns>
        public static int ReturnResult(int n)
        {
            int num;
            if (n == 2)
            {
                return 1 * 1;
            }
            else if (n == 3)
            {
                return 1 * 2;
            }
            else
            {
                num = (int)(n / 3);
                if (n % 3 == 0)
                {
                    return (int)Math.Pow(3, num);
                }
                else if (n % 3 == 1)
                {
                    return (int)(Math.Pow(3, num - 2)) * 2 * 2;
                }
                else
                {
                    return (int)(Math.Pow(3, num - 1)) * 2;
                }
            }
        }
    }
}
