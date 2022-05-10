using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingChess
{
    public class Player
    {

        public Player(int count)
        {
            this.Count = count;
            this.Position =new int[count];
            this.Rank = new int[count];
            for (int i = 0; i < this.Position.Length; i++)
            {
                this.Position[i] = 0;
            }
        }
        //玩家人数
        public int Count { get; set; }
        //玩家位置
        public int[] Position { get; set; }
        //玩家分数,序号i代表玩家,元素Rank[i]代表名次
        public int[] Rank { get; set; }
        //更新玩家分数初始玩家名次都是1
        //遍历玩家位置数组如果有其他玩家的位置比当前玩家位置远则名次加1
        public void RankUpDate ()
        {
            for (int i = 0; i < this.Rank.Length; i++)
            {
                this.Rank[i] = 1;
            }
            for (int i = 0; i < Position.Length; i++)
            {
                for (int j = 0; j < Position.Length; j++)
                {
                    if (j!=i)
                    {
                        if(Position[j]>Position[i])
                        {
                            Rank[i]++;
                        }
                    }
                }
            }
        }
        //更新玩家位置，初始玩家位置都是0
        //将投掷的骰子点数加到当前玩家位置上
        public void PositionUpdate(Dice dice,int player)
        {
            Position[player] = Position[player] + dice.MoveNum;
        }
    }
}
