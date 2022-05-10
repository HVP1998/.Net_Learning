using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FactoryModel
{
    public class Acer:Laptop
    {
        public override void ShowMsg()
        {
            Console.WriteLine("acer Laptop");
        }
    }
}
