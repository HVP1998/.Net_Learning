using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AbstractClass
{
    public class MP4:MobileStorage
    {
        public MP4(string brand, int capacity, double price) : base(brand, capacity, price)
        {

        }
        public override void Read()
        {
            Console.WriteLine("MP4 Read");
        }
        public override void Write()
        {
            Console.WriteLine("MP4 Write");
        }
    }
}
