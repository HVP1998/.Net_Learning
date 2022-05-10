using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Dice dice = new Dice();
            Player players = null;
            int palyerCount = 0;
            string gameStart = "N";
            string gamePlayers = "0";
            try
            {
                //判断进入游戏还是退出
                while (true)
                {
                    Console.Write("输入Y开始游戏输入N直接退出：");
                    gameStart = Console.ReadLine();
                    if (gameStart == "Y")
                    {
                        break;
                    }
                    else if (gameStart == "N")
                    {
                        Console.WriteLine("游戏退出！");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误请仔细阅读规则！");
                        continue;
                    }
                }
                //决定玩家人数
                while (true)
                {
                    Console.Write("输入游戏玩家人数：");
                    gamePlayers = Console.ReadLine();
                    try
                    {
                        palyerCount = Convert.ToInt32(gamePlayers);
                        if ((palyerCount > 1) && (palyerCount < 5))
                        {
                            players = new Player(palyerCount);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("请注意输入大于1小于5的整数！");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("请注意输入大于1小于5的整数！");
                        continue;
                    }
                }

                Console.Clear();
                game.p = players;
                game.GameInitial();
                //进行游戏，有任意一方完成游戏则推出
                while (true)
                {
                    
                    for (int i = 0; i < players.Position.Length; i++)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        dice.Throw();
                        players = game.Gameing(i, dice);
                        if (players.Position[i] >= 169)
                        {
                            Console.WriteLine("玩家{0}获胜，游戏结束", i);
                            break;
                        }
                    }
                    
                }
            }
            catch
            {

            }
            Console.ReadKey();
        }
    }
}
