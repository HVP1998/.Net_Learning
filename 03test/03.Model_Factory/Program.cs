using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Model_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string brand;
            try
            {
                while(true)
                {
                    Console.Write("Please enter brand:");
                    brand = Console.ReadLine();
                    brand = brand.ToLower();
                    if ((brand == "asus") || (brand == "acer") || (brand == "dell") || (brand == "lenovo"))
                    {
                        break;
                    }
                    Console.WriteLine("There is not such kind of laptop, please try others");
                    continue;
                }
                Laptop laptop = PickLap(brand);
                laptop.ShowMsg();
            }
            catch
            {

            }
            Console.ReadKey();
        }


        public static Laptop PickLap(string brand)
        {
            Laptop laptop = null;
            switch(brand)
            {
                case "asus":laptop = new Asus();
                    break;
                case "acer":laptop = new Acer();
                    break;
                case "dell":laptop = new Dell();
                    break;
                case "lenovo":laptop = new Lenovo();
                    break;
            }
            return laptop;
        }
    }
    public abstract class Laptop
    {
        public abstract void ShowMsg();
    }
    public class Asus:Laptop
    {
        public override void ShowMsg()
        {
            Console.WriteLine("ASUS");
        }
    }
    public class Acer:Laptop
    {
        public override void ShowMsg()
        {
            Console.WriteLine("Acer");
        }
    }
    public class Dell:Laptop
    {
        public override void ShowMsg()
        {
            Console.WriteLine("Dell");
        }
    }
    public class Lenovo:Laptop
    {
        public override void ShowMsg()
        {
            Console.WriteLine("Lenovo");
        }
    }
}
