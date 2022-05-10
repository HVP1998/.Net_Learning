using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Abstract_Class
{
    public class MP4:MobileStorage
    {
        public MP4(string mp4_brand,int mp4_capacity, double mp4_price):base(mp4_brand,mp4_capacity,mp4_price)
        {
            
        }
        public override void Read()
        {
            Console.WriteLine("MP4 READ");
        }
        public override void Write()
        {
            Console.WriteLine("MP4 WRITE");
        }
    }
}
