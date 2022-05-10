using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AbstractClass
{
    public abstract class MobileStorage
    {
        public MobileStorage(string brand,int capacity,double price)
        {
            this.Brand = brand;
            this.Capacity = capacity;
            this.Price = price;
        }
        private string _brand;
        public string Brand { get { return _brand; }set { _brand = value; } }
        private int _capacity;
        public int Capacity { get { return _capacity; } set { _capacity = value; } }
        private double _price;
        public double Price { get { return _price; }set { _price = value; } }
        public void ShowMsg()
        {
            Console.WriteLine("BRAND:{0}\tCAPA:{1}GB\tPRICE:{2}￥", this.Brand, this.Capacity, this.Price);
        }
        public abstract void Read();
        public abstract void Write();
    }
}
