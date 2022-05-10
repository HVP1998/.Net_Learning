using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FactoryModel
{
    public class Lenovo:Laptop
    {
        public override void ShowMsg()
        {
            Console.WriteLine("Lenovo Laptop");
        }
    }
}
