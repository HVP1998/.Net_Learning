using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.File_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"1.mp4";
            string target = @"2.mp4";
            FileCopy(source, target);
            Console.WriteLine("Copy Complete");
            Console.ReadKey();
        }
        public static void FileCopy(string source, string target)
        {
            using(FileStream fsread=new FileStream(source,FileMode.Open,FileAccess.Read))
            {
                using(FileStream fswrite=new FileStream(target,FileMode.Create,FileAccess.Write))
                {
                    byte[] buffer = new byte[5 * 1024 * 1024];
                    int r;
                    while(true)
                    {
                        r = fsread.Read(buffer, 0, buffer.Length);
                        if(r==0)
                        {
                            break;
                        }
                        fswrite.Write(buffer, 0, r);
                    }
                }
            }
        }
    }
}
