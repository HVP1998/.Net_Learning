using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[10000000];
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < array.Length; i++)
            {

            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            watch.Restart();
            Console.WriteLine(watch.Elapsed);
            foreach (var item in array)
            {

            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            Console.ReadKey();
        }
    }
}
