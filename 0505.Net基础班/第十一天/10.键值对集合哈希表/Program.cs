using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.键值对集合哈希表
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个键值对集合对象
            Hashtable hashtable = new Hashtable();
            //添加数据
            hashtable[0] = 4;
            hashtable.Add(1, "张三");
            hashtable.Add(2, true);
            hashtable.Add(3, '男');
            hashtable.Add(false, "错误的");
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item+"**********"+hashtable[item]);
            }
            if(!(hashtable.ContainsKey('j')))
            {
                hashtable['j'] = 'j';
            }
            Console.WriteLine(hashtable['j']);
            Console.ReadKey();
        }
    }
}
