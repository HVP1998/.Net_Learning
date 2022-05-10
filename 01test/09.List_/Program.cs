using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace _09.List_
{
    public enum GENDER
    {
        男,
        女,
        LGBT
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht[0] = 5;
            ht.Add(1,6);
            foreach (var item in ht)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
