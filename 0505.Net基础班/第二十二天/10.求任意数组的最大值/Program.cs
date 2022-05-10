using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.求任意数组的最大值
{
    public delegate object DelFindMax(object[] o);
    class Program
    {
        static void Main(string[] args)
        {
            object[] str = { "十年生死两茫茫", "不思量，自难忘", "千里孤坟无处话凄凉", "纵使相逢应不识", "尘满面，鬓如霜", "夜来幽梦忽还乡", "小轩窗，正梳妆", "相顾无言唯有泪千行", "料得年年断肠处", "明月夜，短松冈" };
            object[] nums = { 12.5, 2E2, 33, 1 / 5, -20 };
            Console.WriteLine(FindMaxValue(str,Max_String));
            Console.WriteLine(FindMaxValue(nums,Max_Double));
            Console.ReadKey();
        }
        public static object FindMaxValue(object[] o_array, DelFindMax del)
        {
            return del(o_array);
        }

        public static object Max_String(object[] str)
        {
            object max = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                max = ((string)str[i]).Length > ((string)max).Length ?str[i]:max ;
            }
            return max;
        }
        public static object Max_Double(object[] nums)
        {
            object max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                max = Convert.ToDouble(nums[i]) > Convert.ToDouble(max) ? nums[i] : max;
            }
            return max;
        }
    }
    


}
