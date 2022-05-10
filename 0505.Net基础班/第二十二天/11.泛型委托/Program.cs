using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.泛型委托
{
    public delegate T DelFindMax<T>(T[] o);
    class Program
    {
        static void Main(string[] args)
        {
            String[] str = { "十年生死两茫茫", "不思量，自难忘", "千里孤坟无处话凄凉", "纵使相逢应不识", "尘满面，鬓如霜", "夜来幽梦忽还乡", "小轩窗，正梳妆", "相顾无言唯有泪千行", "料得年年断肠处", "明月夜，短松冈" };
            double[] nums = { 12.5, 2E2, 33, 1 / 5, -20 };
            Console.WriteLine(FindMaxValue<String>(str, Max_String));
            Console.WriteLine(FindMaxValue<double>(nums, Max_Double));
            Console.ReadKey();
        }
        public static T FindMaxValue<T>(T[] o_array, DelFindMax<T> del)
        {
            return del(o_array);
        }

        public static String Max_String(String[] str)
        {
            String max = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                max = str[i].Length > max.Length ? str[i] : max;
            }
            return max;
        }
        public static double Max_Double(double[] nums)
        {
            double max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                max = nums[i] > max ? nums[i] : max;
            }
            return max;
        }
    }



}
