using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AbstractClass
{
    public class Computer
    {
        public static void Read(MobileStorage ms)
        {
            ms.Read();
        }
        public static void Write(MobileStorage ms)
        {
            ms.Write();
        }
    }
}
