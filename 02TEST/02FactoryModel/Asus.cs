using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FactoryModel
{
    public class Asus:Laptop
    {
        public override void ShowMsg()
        {
            Console.WriteLine("ASUS Laptop");
        }
    }
}
