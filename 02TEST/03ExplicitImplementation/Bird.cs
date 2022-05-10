using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExplicitImplementation
{
    public class Bird:IFlyable
    {
        void IFlyable.Fly()
        {
            Console.WriteLine("Interface");
        }
        public void Fly()
        {
            Console.WriteLine("Class");
        }
    }
}
