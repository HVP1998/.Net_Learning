using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Interface_ExplicitComplete
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird b = new Bird();
            b.Fly();
            IFlyable i = new Bird();
            i.Fly();
            Console.ReadKey();
        }
    }
    interface IFlyable
    {
        void Fly();
    }
    public class Bird:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Bird Fly");
        }
        void IFlyable.Fly()
        {
            Console.WriteLine("Interface Complete");
        }
    }
}
