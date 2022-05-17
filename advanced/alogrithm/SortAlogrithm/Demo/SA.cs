using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class SA
    {
        public static void ShowArray<T>(T[] nums)
        {
            foreach (var item in nums)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        public static void BubbleSort(double[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        nums[j] = nums[j + 1] + nums[j];
                        nums[j + 1] = nums[j] - nums[j + 1];
                        nums[j] = nums[j] - nums[j + 1];
                    }
                }
            }
        }
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        public static void SelectionSort(double[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                double max = nums[0];
                int pos = 0;
                for (int j = 1; j < nums.Length - i; j++)
                {
                    if (max < nums[j])
                    {
                        max = nums[j];
                        pos = j;
                    }
                }
                if (pos != nums.Length - 1 - i)
                {
                    nums[pos] = nums[pos] + nums[nums.Length - 1 - i];
                    nums[nums.Length - 1 - i] = nums[pos] - nums[nums.Length - 1 - i];
                    nums[pos] = nums[pos] - nums[nums.Length - 1 - i];
                }
            }
        }
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        public static void InserctionSort(double[] nums)

        {
            for (int i = 1; i < nums.Length; i++)
            {
                int pos = i;
                double max = nums[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[j] > max)
                    {
                        pos = j;
                    }
                }
                if (pos != i)
                {
                    for (int j = pos; j < i; j++)
                    {
                        nums[i] = nums[j] + nums[i];
                        nums[j] = nums[i] - nums[j];
                        nums[i] = nums[i] - nums[j];
                    }
                }

            }
        }
        /// <summary>
        /// 归并排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        /// <returns>排序后的数组</returns>
        public static double[] MergeSort(double[] nums)
        {
            while (true)
            {
                if (nums.Length <= 1)
                {
                    return nums;
                }
                int step = (int)(nums.Length / 2);
                double[] nums1 = nums.Skip(0).Take(step).ToArray();
                double[] nums2 = nums.Skip(step).Take(nums.Length - step).ToArray();
                //ShowArray(nums1); ShowArray(nums2);
                nums1 = MergeSort(nums1);
                nums2 = MergeSort(nums2);
                for (int i = 0; i < nums1.Length; i++)
                {
                    nums[i] = nums1[i];
                }
                for (int i = nums1.Length; i < nums2.Length; i++)
                {
                    nums[i] = nums2[i];
                }
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = 0; j < nums.Length - 1 - i; j++)
                    {
                        if (nums[j] > nums[j + 1])
                        {
                            nums[j] = nums[j] + nums[j + 1];
                            nums[j + 1] = nums[j] - nums[j + 1];
                            nums[j] = nums[j] - nums[j + 1];
                        }
                    }
                }
                //ShowArray(nums);
                return nums;
            }
        }
        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        /// <returns>排序后数组</returns>
        public static double[] QuickSort(double[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            double index = nums[0];
            int left = 0;
            int right = nums.Length - 1;
            string order = "right";
            while (true)
            {
                if (right == left)
                    break;
                if (order == "right")
                {
                    if (nums[right] < index)
                    {
                        nums[left] = nums[right];
                        left++;
                        order = "left";
                    }
                    else
                    {
                        right--;
                    }
                }
                else
                {
                    if (nums[left] >= index)
                    {
                        nums[right] = nums[left];
                        right--;
                        order = "right";
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            nums[left] = index;
            if (left == nums.Length - 1)
            {
                double[] nums_new = nums.Skip(0).Take(left).ToArray();
                nums_new = QuickSort(nums_new);
                for (int i = 0; i < left; i++)
                {
                    nums[i] = nums_new[i];
                }
            }
            else if (left == 0)
            {
                double[] nums_new = nums.Skip(1).Take(nums.Length - 1).ToArray();
                nums_new = QuickSort(nums_new);
                for (int i = 0; i < nums_new.Length; i++)
                {
                    nums[i + 1] = nums_new[i];
                }
            }
            else
            {
                double[] nums1 = nums.Skip(0).Take(left).ToArray();
                double[] nums2 = nums.Skip(left + 1).Take(nums.Length - left - 1).ToArray();
                nums1 = QuickSort(nums1);
                nums2 = QuickSort(nums2);
                for (int i = 0; i < nums1.Length; i++)
                {
                    nums[i] = nums1[i];
                }
                for (int i = nums1.Length + 1; i < nums2.Length; i++)
                {
                    nums[i] = nums2[i];
                }
            }
            return nums;
        }
        /// <summary>
        /// 希尔排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        /// <param name="number">取数据间隔</param>
        /// <returns>排序后数组</returns>
        public static double[] ShellSort(double[] nums, int number)
        {
            if (number == 0)
            {
                return nums;
            }
            for (int i = 0; i <= number; i++)
            {
                List<double> nums_list = new List<double>();
                int j = i;
                while (true)
                {
                    nums_list.Add(nums[j]);
                    j = j + number;
                    if (j > nums.Length - 1)
                        break;
                }
                double[] nums_new = nums_list.ToArray();
                ShowArray(nums_new);
                BubbleSort(nums_new);
                ShowArray(nums_new);
                j = i;
                int k = 0;
                while (true)
                {
                    nums[j] = nums_new[k];
                    j = j + number;
                    k = k + 1;
                    if (j > nums.Length - 1)
                        break;
                }
                ShowArray(nums);
            }
            nums = ShellSort(nums, (int)(number / 2));
            return nums;
        }
        /// <summary>
        /// 构造大根堆
        /// </summary>
        /// <param name="nums">待排序数组</param>
        /// <returns>大根堆</returns>
        public static double[] BigTree(double[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int j = i;
                while (true)
                {
                    if (nums[j] > nums[(int)((j - 1) / 2)])
                    {
                        nums[j] = nums[j] + nums[(int)((j - 1) / 2)];
                        nums[(int)((j - 1) / 2)] = nums[j] - nums[(int)((j - 1) / 2)];
                        nums[j] = nums[j] - nums[(int)((j - 1) / 2)];
                    }
                    j = (int)((j - 1) / 2);
                    if (j <= 0)
                    {
                        break;
                    }
                }
            }
            return nums;
        }
        /// <summary>
        /// 堆排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        /// <returns>排序后数组</returns>
        public static double[] HeapSort(double[] nums)
        {
            nums = BigTree(nums);
            for (int i = nums.Length - 1; i >= 1; i--)
            {
                nums[i] = nums[i] + nums[0];
                nums[0] = nums[i] - nums[0];
                nums[i] = nums[i] - nums[0];
                List<double> nums_list = new List<double>();
                for (int j = 0; j < i; j++)
                {
                    nums_list.Add(nums[j]);
                }
                double[] nums_new = nums_list.ToArray();
                nums_new = BigTree(nums_new);
                for (int j = 0; j < i; j++)
                {
                    nums[j] = nums_new[j];
                }
            }
            return nums;
        }
        /// <summary>
        /// 计数排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        /// <returns>排序后数组</returns>
        public static int[] CountSort(int[] nums)
        {
            int max = nums[0];
            int min = nums[0];
            //确定最大值与最小值
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];
            }
            int[] count = new int[max - min + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i] - min]++;
            }
            for (int i = 1; i < (max - min + 1); i++)
            {
                count[i] = count[i] + count[i - 1];
            }
            int[] nums_new = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums_new[count[nums[i] - min]-1] = nums[i];
                count[nums[i] - min]--;
            }
            return nums_new;
        }
        /// <summary>
        /// 桶排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        /// <param name="count">桶的数量</param>
        /// <returns>排序后的数组</returns>
        public static double[] BucketSort(double[] nums,int count)
        {
            double max = nums[0];
            double min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if(max<nums[i])
                {
                    max = nums[i];
                }
                if(min>nums[i])
                {
                    min = nums[i];
                }
            }
            double step = (max - min) / count;
            List<List<double>> bucket = new List<List<double>>();
            for (int i = 0; i < count; i++)
            {
                bucket.Add(new List<double>());
            }
            for (int i=0;i< nums.Length; i++)
            {
                if ((nums[i]>=min)&&(nums[i] <min+1* step))
                {
                    bucket[0].Add(nums[i]);
                }
                else if ((nums[i] >= min + 1 * step) && (nums[i] < min + 2 * step))
                {
                    bucket[1].Add(nums[i]);
                }
                else if ((nums[i] >= min + 2 * step) && (nums[i] < min + 3 * step))
                {
                    bucket[2].Add(nums[i]);
                }
                else if ((nums[i] >= min + 2 * step) && (nums[i] < min + 3 * step))
                {
                    bucket[3].Add(nums[i]);
                }
                else
                {
                    bucket[4].Add(nums[i]);
                }
            }
            List<double[]> bucket_new = new List<double[]>();
            for (int i = 0; i < count; i++)
            {
                bucket_new.Add(null);
            }
            for (int i = 0; i < count; i++)
            {
                bucket_new[i] = bucket[i].ToArray();
                BubbleSort(bucket_new[i]);
            }
            List<double> result = new List<double>();
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < bucket_new[i].Length; j++)
                {
                    result.Add(bucket_new[i][j]);
                }
            }
            nums = result.ToArray();
            return nums;
        }
        /// <summary>
        /// 基数排序
        /// </summary>
        /// <param name="nums">待排序数组</param>
        /// <returns>返回值</returns>
        public static string[] RadixSort(string[] nums)
        {
            int max_length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i].Length>max_length)
                {
                    max_length = nums[i].Length;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i].Length<max_length)
                {
                    for (int j = 0; j < max_length - nums[i].Length; j++)
                    {
                        nums[i] = "0" + nums[i];
                    }
                }
            }
            ShowArray<string>(nums);
            for (int i = max_length-1; i >=0 ; i--)
            {
                for (int j = 0; j < nums.Length-1; j++)
                {
                    for (int k = 0; k < nums.Length-1-j; k++)
                    {
                        if(Convert.ToInt32(nums[k].Substring(i,1))>Convert.ToInt32( nums[k+1].Substring(i, 1)))
                        {
                            string exchange = nums[k];
                            nums[k] = nums[k + 1];
                            nums[k + 1] = exchange;
                        }
                    }
                }
            }
            ShowArray<string>(nums);
            return nums;
        }
    }
}
