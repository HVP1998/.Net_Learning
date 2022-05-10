
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExplicitImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird b = new Bird();
            IFlyable i = new Bird();
            b.Fly();
            i.Fly();
            Console.ReadKey();
        }
    }
}
