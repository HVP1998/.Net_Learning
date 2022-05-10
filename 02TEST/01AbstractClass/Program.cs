using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileStorage[] ms_array = new MobileStorage[3];
            ms_array[0] = new HardDisk("WestDigital", 2048, 389);
            ms_array[1] = new MP4("PurpleLigt", 64, 289);
            ms_array[2] = new FlashDisk("KingSton", 64, 89);
            foreach (var item in ms_array)
            {
                Computer.Read(item);
                Computer.Write(item);
                item.ShowMsg();
            }
            Console.ReadKey();
        }
    }
}
