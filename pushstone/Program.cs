using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pushstone
{
    internal class Program
    {
        static void Main(string[] args)
        {






            Map();




        }


        static void Map()
        {

            int i = 0;
            int j = 0;
            int makeMap = 0;
            int x = 0;
            int y = 0;
            Random rand = new Random();

            int coinCount = 0;
            int coin_x = 0;
            int coin_y = 0;
            int coin = 0;
            int move = 0;

            Console.Write("만들 맵의 크기를 입력해주세요.---->");

            int.TryParse(Console.ReadLine(), out makeMap);

            //배열 변수 선언
            char[,] Map = new char[makeMap, makeMap];


            //맵 저장과 출력
            for (i=0; i<makeMap; i++)
            {
                for (j=0; j<makeMap; j++)
                {
                    Map[i, j] = '□';

                  

                    if (i == y && j == x)
                    {
                        Map[i, j] = '☆';
                    }
                }
            }

            Console.Clear();
            //배열 출력
            for (i=0; i<makeMap; i++)
            {
                for (j=0; j<makeMap; j++)
                {
                    Console.Write("{0} ", Map[i, j]);
                }
                Console.WriteLine();
            }


            //입렵값 주기
            while (true)
            {
                Console.WriteLine("현재까지 먹은 코인 = {0}", coinCount);
                if (coinCount == 10)
                {
                    Console.WriteLine("게임을 종료합니다");

                    break;
                }

                ConsoleKeyInfo someting = Console.ReadKey();

                if (someting.Key == ConsoleKey.UpArrow)
                {
                    if (y > 1)
                    {
                        y -= 1;
                    }
                    else
                    {
                        y = 1;
                    }



                }
                else if (someting.Key == ConsoleKey.DownArrow)
                {
                    //u_x++;
                    if (y < makeMap-2)
                    {
                        y += 1;
                    }
                    else
                    {


                        y = makeMap-2;

                    }


                }
                else if (someting.Key == ConsoleKey.LeftArrow)
                {
                    //u_y--;
                    if (x > 1)
                    {
                        x -= 1;
                    }
                    else
                    {
                        x = 1;
                        Console.Write("");
                    }


                }
                else if (someting.Key == ConsoleKey.RightArrow)
                {
                    //u_y++;
                    if (x < makeMap-2)
                    {
                        x += 1;
                    }
                    else
                    {
                        x = makeMap-2;
                    }


                }

                move += 1;

                if (move >= 6)
                {
                    if (coin == 0)
                    {
                        while (true)
                        {
                            coin_x = rand.Next(0, makeMap-1);
                            coin_y = rand.Next(0, makeMap-1);

                            if (coin_x == x && coin_y == y)
                            {
                                continue;
                            }
                            else
                            {
                                coin = 1;
                                move = 0;
                                break;
                            }
                        }

                    }
                }

                if (coin_x == x && coin_y == y)
                {
                    coin = 0;
                    coinCount += 1;
                }





                // 입력 저장 부분 
                for (i=0; i<makeMap; i++)
                {
                    for (j=0; j<makeMap; j++)
                    {
                        Map[i, j] = '　';

                        if (i==0 || j==0)
                        {
                            Map[i, j] = '■';
                        }
                        if (i == makeMap-1 || j == makeMap-1)
                        {
                            Map[i, j] = '■';
                        }




                        if (i == y && j == x)
                        {
                            Map[i, j] = '☆';
                        }
                        if (coin == 1)
                        {
                            Map[coin_y, coin_x] = 'ⓒ';
                        }
                    }
                }

                Console.Clear();
                for (i=0; i<makeMap; i++)
                {
                    for (j=0; j<makeMap; j++)
                    {
                        Console.Write("{0}", Map[i, j]);
                    }
                    Console.WriteLine();
                    

                }


                //


            }

        }


    }
}
