using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Abstract_Class
{
    public class HardDisk : MobileStorage
    {
        public HardDisk(string brand, int capacity, double price) : base(brand, capacity, price)
        {

        }
        public override void Read()
        {
            Console.WriteLine("HardDisk READ");
        }
        public override void Write()
        {
            Console.WriteLine("HardDisk WRITE");
        }
    }
}
