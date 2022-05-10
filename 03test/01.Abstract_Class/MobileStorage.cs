using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Abstract_Class
{
    public abstract class MobileStorage
    {
        public MobileStorage(string brand,int capacity,double price)
        {
            this.Brand = brand;
            this.Capacity = capacity;
            this.Price = price;

        }

        public string Brand { get; set; }

        public int Capacity { get; set; }

        private double Price { get; set; }

        public void ShowMsg()
        {
            Console.WriteLine("brand:{0}\t\tcapacity:{1}GB\t\tprice:{2}￥", this.Brand, this.Capacity, this.Price);
        }
        public abstract void Read();

        public abstract void Write();
    }
}
