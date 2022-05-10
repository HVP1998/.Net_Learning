using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileStorage mp4 = new MP4("PurpleLight",32,254);
            MobileStorage hd = new HardDisk("WestDigital",2048,489);
            MobileStorage fd = new FlashDisk("Kingston",64,89);
            MobileStorage[] ms_array = { mp4, hd, fd };
            Computer cm = new Computer();
            foreach (var item in ms_array)
            {
                item.ShowMsg();
                cm.Ms = item;
                cm.Read();
                cm.Write();
            }
            Console.ReadKey();
        }
    }
}
