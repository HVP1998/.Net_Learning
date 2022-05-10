using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingChess
{
    public class Game
    {
        public Player p { get; set; }
        string[] map = new string[170];
        /// <summary>
        /// 游戏地图的绘制
        /// </summary>
        public void MapDrawing()
        {
            #region 游戏地图设计
            map[0] = "□";
            for (int i = 1; i < map.Length; i++)
            {
                if (i % 6 == 0)
                {
                    map[i] = "○";
                }
                else if (i % 11 == 0)
                {
                    map[i] = "△";
                }
                else if (i % 10 == 0)
                {
                    map[i] = "◇";
                }
                else if (i % 13 == 0)
                {
                    map[i] = "？";
                }
                else
                {
                    map[i] = "□";
                }
            }
            map[169] = "终";
            if (p.Position.Length == 2)
            {
                map[p.Position[0]] = "①"; map[p.Position[1]] = "②";
            }
            else if (p.Position.Length == 3)
            {
                map[p.Position[0]] = "①"; map[p.Position[1]] = "②"; map[p.Position[2]] = "③";
            }
            else
            {
                map[p.Position[0]] = "①";
                map[p.Position[1]] = "②";
                map[p.Position[2]] = "③";
                map[p.Position[3]] = "④";
            }
            #endregion

            #region 游戏规则说明
            for (int i = 0; i < 50; i++)
            {
                Console.Write("**");
            }
            Console.WriteLine();
            Console.WriteLine("* 1.随机按下按钮投掷骰子");
            Console.WriteLine("* 2.□无特殊效果");
            Console.WriteLine("* 3.○前进三格");
            Console.WriteLine("* 4.△与前一名选手交换位置");
            Console.WriteLine("* 5.◇后退5格");
            Console.WriteLine("* 6.？进入幸运转盘，再次投掷色子双数前进6格单数后退3格");
            Console.WriteLine("* 7.当一名玩家从后面追上另一名玩家并且达到同一位置此玩家前进4格");
            for (int i = 0; i < 50; i++)
            {
                Console.Write("**");
            }
            Console.WriteLine();
            #endregion

            #region 游戏地图绘制
            for (int i = 0; i < map.Length; i++)
            {
                if (i < 49)
                {
                    Console.Write(map[i]);
                }
                else if (i == 49)
                {
                    Console.WriteLine(map[i]);
                }
                else if (i <= 59)
                {
                    string str = "";
                    for (int j = 0; j < 49; j++)
                    {
                        str = str + "  ";
                    }
                    Console.WriteLine(str + map[i]);
                }
                else if (i <= 108)
                {
                    Console.Write(map[map.Length - i]);
                }
                else if (i == 109)
                {
                    Console.WriteLine(map[map.Length - i]);
                }
                else if (i <= 119)
                {
                    Console.WriteLine(map[i]);
                }
                else
                {
                    Console.Write(map[i]);
                }
            }
            #endregion
            Console.WriteLine();
        }
        /// <summary>
        /// 游戏初始化
        /// </summary>
        /// <param name="p">玩家对象</param>
        public void GameInitial()
        {
            MapDrawing();
        }
        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="i">玩家i</param>
        /// <param name="d">骰子</param>
        /// <returns></returns>
        public Player Gameing(int i, Dice d)
        {
            //更新位置
            p.PositionUpdate(d, i);
            //更新名次
            if (p.Position[i] >= 169)
                p.Position[i] = 169;
            switch (map[p.Position[i]])
            {
                case "○":
                    {
                        p.Position[i] += 3;
                        MapDrawing();
                        Console.WriteLine("玩家{0}踩到○前进3步", i);
                    }
                    break;
                case "△":
                    {
                        if (p.Rank[i] != 1)
                        {
                            for (int j = 0; j < p.Rank.Length; j++)
                            {
                                if (j != 1)
                                {
                                    if (p.Rank[j] == p.Rank[i] - 1)
                                    {
                                        ExchangeTwoNums(ref p.Position[i], ref p.Position[j]);
                                        ExchangeTwoNums(ref p.Rank[i], ref p.Rank[j]);
                                        MapDrawing();
                                        Console.WriteLine("玩家{0}与玩家{1}交换位置", i, j);
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "◇":
                    {
                        p.Position[i] -= 5;
                        MapDrawing();
                        Console.WriteLine("玩家{0}踩到◇后退5步", i);
                    }
                    break;
                case "？":
                    {
                        MapDrawing();
                        Console.WriteLine("玩家{0}踩到？进入幸运轮盘", i);
                        d.Throw();
                        if (d.ThrowNum % 2 == 0)
                        {
                            p.Position[i] += 6;
                            Console.WriteLine("玩家{0}在幸运轮盘得到双数前进6步", i);
                        }
                        else
                        {
                            p.Position[i] -= 3;
                            Console.WriteLine("玩家{0}在幸运轮盘得到单数数后退3步", i);
                        }
                    }
                    break;
                case "□":
                    MapDrawing();
                    break;
                case "①":
                    {
                        p.Position[i] += 2;
                        MapDrawing();
                        Console.WriteLine("玩家{0}踩到①前进2步", i+1);
                    }
                    break;
                case "②":
                    {
                        p.Position[i] += 2;
                        MapDrawing();
                        Console.WriteLine("玩家{0}踩到②前进2步", i+1);
                    }
                    break;
                case "③":
                    {
                        
                        p.Position[i] += 2;
                        MapDrawing();
                        Console.WriteLine("玩家{0}踩到③前进2步", i+1);
                    }
                    break;
                case "④":
                    {
                        
                        p.Position[i] += 2;
                        MapDrawing();
                        Console.WriteLine("玩家{0}踩到④前进2步", i+1);
                    }
                    break;
            }
            
            Console.WriteLine("玩家{0}前进{1}步", i + 1, d.MoveNum);
            return p;
        }
        /// <summary>
        /// 交换两个数字
        /// </summary>
        /// <param name="num1">待交换数字1</param>
        /// <param name="num2">待交换数字2</param>
        private void ExchangeTwoNums(ref int num1, ref int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
        }

    }
}
