using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Abstract_Class
{
    public class Computer
    {
        public MobileStorage Ms { set ; get; }
        public void Read()
        {
            this.Ms.Read();
        }
        public void Write()
        {
            this.Ms.Write();
        }
    }
}
