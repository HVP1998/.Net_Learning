using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingChess
{
    public class Dice
    {
        public Dice()
        {
            ThrowNum = 0;
        }
        public void Throw()
        {
            Random random = new Random();
            this.MoveNum = random.Next(1, 7);
            ThrowNum++;
        }
        public int MoveNum { get; set; }

        public int ThrowNum { get; set; }
    }
}
