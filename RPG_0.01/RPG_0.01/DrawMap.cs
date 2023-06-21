using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_0._01
{
    public class DrawMap
    {

     

        public void DRAWMap()
        {
            Random rand = new Random();
            string[,] Map = new string[20, 20];
            List<Shopitem> inventory = new List<Shopitem>();

            //배틀 관련 선언
            Battle fight = new Battle();
            Orc orcMonster = new Orc();
            int userHp = 50;
            int userDamage = 10;

            //카드게임 선언
            Card card = new Card();
            int coin = 1000;

            //상점 클래스 선언
            market shop = new market();

            Heal heal = new Heal();

            //사용자 시작 좌표
            int user_y = 10;
            int user_x = 10;

            //Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Map[i, j] = "　";

                    if (i == 0 || j == 0)
                    {
                        Map[i, j] = "■";
                    }
                    if (i == 19 || j == 19)
                    {
                        Map[i, j] = "■";
                    }
                    
                    if (i == user_y && j == user_x)
                    {
                        Map[i, j] = "♥";
                    }
                }
            }

            Console.WriteLine("현재 사용자의 체력 = {0}, 소지금 {1}", userHp, coin);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("{0}", Map[i, j]);
                }
                Console.WriteLine();
            }

            while (true)
            {


                ConsoleKeyInfo UserInput = Console.ReadKey();

                Console.Clear();

                Console.WriteLine("현재 사용자의 체력 = {0}, 소지금 {1}", userHp, coin);

                if (UserInput.Key == ConsoleKey.W)
                {
                    if (user_y > 1)
                    {
                        if (Map[(user_y-1), user_x] == "※")
                        {
                            Console.Clear();
                            orcMonster.Initilize("오크", 30, 5);
                            Console.WriteLine("전투를 시작합니다.\n");

                            while (true)
                            {

                                if (userHp == 0)
                                {
                                    Console.WriteLine("사용자의 체력이 {0}이 되어 게임을 종료합니다",
                                        userHp);
                                    break;
                                }
                                else if (orcMonster.hp == 0)
                                {
                                    Console.WriteLine("\n{0}의 체력이 {1}이 되어 싸움에서 승리하였습니다.",
                                        orcMonster.name, orcMonster.hp);
                                    break;
                                }
                                Thread.Sleep(1000);

                                fight.battle(ref userHp, ref orcMonster.damage);
                                Console.WriteLine("현재 유저의 hp 는 ={0},  대미지 = {1}",
                                    userHp, orcMonster.damage);
                                Thread.Sleep(1500);

                                fight.battle(ref orcMonster.hp, ref userDamage);
                                Console.WriteLine("현재 {0}의 hp 는 ={1},  대미지 = {2}",
                                    orcMonster.name, orcMonster.hp, userDamage);

                            }
                            user_y -= 1;
                            Map[user_y, user_x] ="♥";
                            Map[user_y+1, user_x] ="　";

                        }
                        else if (Map[(user_y-1), user_x] == "♣")
                        {
                            Console.Clear();
                            Console.WriteLine("카드 게임을 시작합니다.");
                            card.cardGame(ref coin);

                            user_y -= 1;
                            Map[user_y, user_x] ="♥";
                            Map[user_y+1, user_x] ="　";
                        }
                        else if (Map[(user_y-1), user_x] == "☎")
                        {
                            Console.Clear();
                            Console.WriteLine("상점을 방문했습니다.");
                            heal.healling(ref userHp);
                            shop.Shopping(ref coin ,ref inventory);

                            user_y -= 1;
                            Map[user_y, user_x] ="♥";
                            Map[user_y+1, user_x] ="　";
                        }
                        else
                        {
                            user_y -= 1;
                            Map[user_y, user_x] ="♥";
                            Map[user_y+1, user_x] ="　";
                        }

                    }
                    else
                    {
                        user_y = 1;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }



                }
                else if (UserInput.Key == ConsoleKey.S)
                {
                    if (user_y < 18)
                    {
                        if (Map[(user_y+1), user_x] == "※")
                        {
                            Console.Clear();
                            orcMonster.Initilize("오크", 30, 5);
                            Console.WriteLine("전투를 시작합니다.\n");

                            while (true)
                            {

                                if (userHp == 0)
                                {
                                    Console.WriteLine("사용자의 체력이 {0}이 되어 게임을 종료합니다",
                                        userHp);
                                    break;
                                }
                                else if (orcMonster.hp == 0)
                                {
                                    Console.WriteLine("\n{0}의 체력이 {1}이 되어 싸움에서 승리하였습니다.",
                                        orcMonster.name, orcMonster.hp);
                                    break;
                                }
                                Thread.Sleep(1000);

                                fight.battle(ref userHp, ref orcMonster.damage);
                                Console.WriteLine("현재 유저의 hp 는 ={0},  대미지 = {1}",
                                    userHp, orcMonster.damage);
                                Thread.Sleep(1000);

                                fight.battle(ref orcMonster.hp, ref userDamage);
                                Console.WriteLine("현재 {0}의 hp 는 ={1},  대미지 = {2}",
                                    orcMonster.name, orcMonster.hp, userDamage);

                            }

                            user_y += 1;
                            Map[user_y, user_x] ="♥";
                            Map[user_y-1, user_x] ="　";

                        }
                        else if (Map[(user_y+1), user_x] == "♣")
                        {
                            Console.Clear();
                            Console.WriteLine("카드 게임을 시작합니다.");
                            card.cardGame(ref coin);
                        }
                        else if (Map[(user_y+1), user_x] == "☎")
                        {
                            Console.Clear();
                            Console.WriteLine("상점을 방문했습니다.");
                            heal.healling(ref userHp);
                            shop.Shopping(ref coin, ref inventory);
                        }
                        else
                        {
                            user_y += 1;
                            Map[user_y, user_x] ="♥";
                            Map[user_y-1, user_x] ="　";
                        }

                    }
                    else
                    {
                        user_y = 18;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }
                else if (UserInput.Key == ConsoleKey.A)
                {
                    if (user_x > 1)
                    {
                        if (Map[user_y, (user_x-1)] == "※")
                        {
                            Console.Clear();
                            orcMonster.Initilize("오크", 30, 5);
                            Console.WriteLine("전투를 시작합니다.\n");

                            while (true)
                            {

                                if (userHp == 0)
                                {
                                    Console.WriteLine("사용자의 체력이 {0}이 되어 게임을 종료합니다",
                                        userHp);
                                    break;
                                }
                                else if (orcMonster.hp == 0)
                                {
                                    Console.WriteLine("\n{0}의 체력이 {1}이 되어 싸움에서 승리하였습니다.",
                                        orcMonster.name, orcMonster.hp);
                                    break;
                                }
                                Thread.Sleep(1000);

                                fight.battle(ref userHp, ref orcMonster.damage);
                                Console.WriteLine("현재 유저의 hp 는 ={0},  대미지 = {1}",
                                    userHp, orcMonster.damage);
                                Thread.Sleep(1000);

                                fight.battle(ref orcMonster.hp, ref userDamage);
                                Console.WriteLine("현재 {0}의 hp 는 ={1},  대미지 = {2}",
                                    orcMonster.name, orcMonster.hp, userDamage);
                            }
                            user_x -= 1;
                            Map[user_y, user_x] ="♥";
                            Map[user_y, user_x+1] ="　";
                        }
                        else if (Map[user_y, (user_x-1)] == "♣")
                        {
                            Console.Clear();
                            Console.WriteLine("카드 게임을 시작합니다.");
                            card.cardGame(ref coin);
                        }
                        else if (Map[user_y, (user_x-1)] == "☎")
                        {
                            Console.Clear();
                            Console.WriteLine("상점을 방문했습니다.");
                            heal.healling(ref userHp);
                            shop.Shopping(ref coin, ref inventory);
                        }
                        else
                        {
                            user_x -= 1;
                            Map[user_y, user_x] ="♥";
                            Map[user_y, user_x+1] ="　";
                        }

                    }
                    else
                    {
                        user_x = 1;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }
                else if (UserInput.Key == ConsoleKey.D)
                {
                    if (user_x < 18)
                    {
                        if (Map[user_y, (user_x+1)] == "※")
                        {
                            Console.Clear();
                            orcMonster.Initilize("오크", 30, 5);
                            Console.WriteLine("전투를 시작합니다.\n");

                            while (true)
                            {

                                if (userHp == 0)
                                {
                                    Console.WriteLine("사용자의 체력이 {0}이 되어 게임을 종료합니다",
                                        userHp);
                                    break;
                                }
                                else if (orcMonster.hp == 0)
                                {
                                    Console.WriteLine("\n{0}의 체력이 {1}이 되어 싸움에서 승리하였습니다.",
                                        orcMonster.name, orcMonster.hp);
                                    break;
                                }
                                Thread.Sleep(1000);

                                fight.battle(ref userHp, ref orcMonster.damage);
                                Console.WriteLine("현재 유저의 hp 는 ={0},  대미지 = {1}",
                                    userHp, orcMonster.damage);
                                Thread.Sleep(1000);

                                fight.battle(ref orcMonster.hp, ref userDamage);
                                Console.WriteLine("현재 {0}의 hp 는 ={1},  대미지 = {2}",
                                    orcMonster.name, orcMonster.hp, userDamage);
                            }
                            user_x += 1;
                            Map[user_y, user_x] ="&";
                            Map[user_y, user_x-1] ="　";
                        }
                        else if (Map[user_y, (user_x+1)] == "♣")
                        {
                            Console.Clear();
                            Console.WriteLine("카드 게임을 시작합니다.");
                            card.cardGame(ref coin);
                        }
                        else if (Map[user_y, (user_x+1)] == "☎")
                        {
                            Console.Clear();
                            Console.WriteLine("상점을 방문했습니다."); 
                            heal.healling(ref userHp);
                            shop.Shopping(ref coin, ref inventory);
                        }
                        else
                        {
                            user_x += 1;
                            Map[user_y, user_x] ="♥";
                            Map[user_y, user_x-1] ="　";
                        }

                    }
                    else
                    {
                        user_x = 18;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }
                }
                else if (UserInput.Key == ConsoleKey.M)
                {

                    int mon_y = rand.Next(1, 18);
                    int mon_x = rand.Next(1, 18);
                    if (mon_y!=user_y || mon_x!=user_x)
                    {
                        Map[mon_y, mon_x] = "※";
                    }

                }
                else if (UserInput.Key == ConsoleKey.P)
                {
                    int shop_y = rand.Next(1, 18);
                    int shop_x = rand.Next(1, 18);
                    if (shop_y!=user_y && shop_x !=user_x)
                    {
                        Map[shop_y, shop_x] = "☎";
                    }
                }
                else if (UserInput.Key == ConsoleKey.C)
                {
                    int card_y = rand.Next(1, 18);
                    int card_x = rand.Next(1, 18);
                    if (card_y!=user_y && card_x !=user_x)
                    {
                        Map[card_y, card_x] = "♣";
                    }
                }
                else if (UserInput.Key == ConsoleKey.I)
                {
                    shop.Shopping(ref coin, ref inventory);
                }



                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        Console.Write("{0}", Map[i, j]);
                    }
                    Console.WriteLine();
                }
            }



        }


    }






}
