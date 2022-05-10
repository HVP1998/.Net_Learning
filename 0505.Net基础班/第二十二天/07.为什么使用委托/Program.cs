using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.为什么使用委托
{
    public delegate string DelFormalizeString(string str);
    class Program
    {
        
        static void Main(string[] args)
        {
            //1.将所有的字符串改为大写
            //2.将所有的字符串改为小写
            //3.将所有的字符串加上引号
            string[] str_array = { "ABcdEfg", "hIJklmn", "OpqRStUVw", "XYZ" };
            //
            DelFormalizeString del1 = new DelFormalizeString(StringToUpper);
            FormalizeString(str_array, del1);
            foreach (var item in str_array)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");
            DelFormalizeString del2 = StringToLower;
            FormalizeString(str_array, del2);
            foreach (var item in str_array)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");
            FormalizeString(str_array, StringAddQuotes);
            foreach (var item in str_array)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");
            Console.ReadKey();

        }

        /// <summary>
        /// 将字符串数组中的字符串做处理
        /// </summary>
        /// <param name="str_array">字符串数组</param>
        /// <param name="del">调用的函数</param>
        public static void FormalizeString(string[] str_array,DelFormalizeString del)
        {
            for (int i = 0; i < str_array.Length; i++)
            {
                str_array[i] = del(str_array[i]);
            }
        }
        /// <summary>
        /// 将字符串改为大写
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns></returns>
        public static string StringToUpper(string str)
        {
            return str.ToUpper();
        }
        /// <summary>
        /// 将字符串改为小写
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns></returns>
        public static string StringToLower(string str)
        {
            return str.ToLower();
        }
        /// <summary>
        /// 将字符串加上引号
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StringAddQuotes(string str)
        {
            return "\"" + str + "\"";
        }
    }
}
