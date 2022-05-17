using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] nums = { 1, 12, 11, 8, 5, 4, 7, 10, 6, 3, 9, 2 };
            //double[] nums = { 1, 10, 2, 8, 5, 4, 7, 10, 6, 3, 9, 2 };
            //int[] nums = { 1, 10, 2, 8, 5, 4, 7, 10, 6, 3, 9, 2 };
            string[] nums = { "1", "10", "2", "8", "5", "4", "7", "10", "6", "3", "9", "2" };


            //SA.BubbleSort(nums);
            //SA.SelectionSort(nums);
            //SA.InserctionSort(nums);
            //nums = SA.QuickSort(nums);
            //nums = SA.ShellSort(nums,(int)(nums.Length/2));
            //nums = SA.HeapSort(nums);
            //nums = SA.CountSort(nums);
            //nums = SA.BucketSort(nums,5);
            nums = SA.RadixSort(nums);

            foreach (var item in nums)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
