using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FactoryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name;
                while (true)
                {
                    Console.Write("Please enter name:");
                    name = Console.ReadLine();
                    name = name.ToLower();
                    if((name=="asus")||(name=="acer")||(name=="lenovo")||(name=="dell"))
                    {
                        break;
                    }
                    Console.WriteLine("There is not the brand.");
                }
                Laptop laptop = PickLaptop(name);
                laptop.ShowMsg();
                Console.ReadKey();
            }
            catch
            {

            }
        }

        public static Laptop PickLaptop(string name)
        {
            Laptop laptop = null;
            switch (name)
            {
                case "asus":
                    laptop = new Asus();
                    break;
                case "acer":
                    laptop = new Acer();
                    break;
                case "dell":
                    laptop = new Dell();
                    break;
                case "lenovo":
                    laptop = new Lenovo();
                    break;
            }
            return laptop;
        }
    }
}
