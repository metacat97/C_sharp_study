using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Map();

        }


        static void Map()
        {
           
            

            int makeMap = 0;
            Random rand = new Random();

            // int s_y = 2;
            // int s_x = 2;
            


            int s1_y = 0;
            int s1_x = 0;

            int s2_y = 0;
            int s2_x = 0;

            int s3_y = 0;
            int s3_x = 0;

            int stone1 = 0;
            int stone2 = 0;
            int stone3 = 0;


            int stoneCheck = 0;
            int stoneCount = 0;


            // int stoneMove = 0;

            int score = 0;
            //int stoneCount = 0;

            Console.Write("만들 맵의 크기를 입력해주세요.----->");
            //입력받는 스트링 인트형변환
            int.TryParse(Console.ReadLine(), out makeMap);

            int u_y = makeMap/2;
            int u_x = makeMap/2;
            //int userMove = 0;


            // 맵 배열 변수 선언
            char[,] Map = new char[makeMap, makeMap];

            // 돌 배열 선언
            //int[,] stoneMap = new int[makeMap, makeMap];
            //for (int i = 0; i < makeMap; i++)
            //{
            //    for(int j = 0; j < makeMap; j++)
            //    {
            //        stoneMap[i, j] = i+1;  
            //    }    
            //}    

            //맵 저장과 출력
            for (int i = 0; i < makeMap; i++)
            {
                for(int j = 0; j< makeMap; j++)
                {
                    Map[i, j] ='□';
                    if (i==0 || j==0)
                    { 
                        Map[i, j] ='■';

                    }
                    if(i==makeMap-1 || j==makeMap-1)
                    {
                        Map[i, j] ='■';
                    }
                    

                    

                    if (i == u_y && j == u_x)
                    {
                        Map[i, j] = '★';
                    }

                }
            }


            Console.Clear();

            //배열 출력
            
            for (int i = 0; i < makeMap; i++)
            {
                for (int j = 0;j< makeMap; j++)
                {
                    Console.Write("{0}", Map[i, j]);
                }
                Console.WriteLine();
            }

            //====================================================================

            //stoneCheck = Map[] 


            while (true)
            {
                // Console.Write("현재까지 스코어 = {0}", score);
                //if (score == 10)
                //{
                //    Console.WriteLine("게임을 종료합니다.");

                //    break;

                //}



                ConsoleKeyInfo someting = Console.ReadKey();

                if (someting.Key == ConsoleKey.UpArrow)
                {



                    if (u_y > 1)
                    {
                        u_y -= 1;

                        if (u_y == s1_y || u_x == s1_x)
                        {
                            u_y += 1;


                            s1_y -= 1;

                        }

                    }
                    else
                    {
                        u_y = 1;
                    }

                    



                }
                else if (someting.Key == ConsoleKey.DownArrow)
                {
                    //u_x++;
                    if (u_y < makeMap-2)
                    {
                        u_y += 1;
                    }
                    else
                    {
                        u_y = makeMap-2;
                    }


                }
                else if (someting.Key == ConsoleKey.LeftArrow)
                {
                    //u_y--;
                    if (u_x > 1)
                    {
                        u_x -= 1;
                    }
                    else
                    {
                        u_x = 1;
                        Console.Write("");
                    }


                }
                else if (someting.Key == ConsoleKey.RightArrow)
                {
                    //u_y++;
                    if (u_x < makeMap-2)
                    {
                        u_x += 1;
                    }
                    else
                    {
                        u_x = makeMap-2;
                    }
                }


                if (stoneCount <= 1)
                {
                    s1_y = rand.Next(1, makeMap-2);
                    s1_x = rand.Next(1, makeMap-2);


                    s2_y = rand.Next(1, makeMap-2);
                    s2_x = rand.Next(1, makeMap-2);


                    s3_y = rand.Next(1, makeMap-2);
                    s3_x = rand.Next(1, makeMap-2);

                }



                stoneCount += 3;

                stone1 = Map[s1_y, s1_x];
                stone2 = Map[s2_y, s2_x];
                stone3 = Map[s3_y, s3_x];


                //입력 저장 부분
                for (int i = 0; i < makeMap; i++)
                {
                    for (int j = 0; j < makeMap; j++)
                    {
                        Map[i, j] = '□';

                        if (i==0 || j==0)
                        {
                            Map[i, j] = '■';
                        }
                        if (i == makeMap-1 || j == makeMap-1)
                        {
                            Map[i, j] = '■';
                        }




                        if (i == u_y && j == u_x)
                        {
                            Map[i, j] = '★';
                        }
                        //돌 3개 출력 

                        if (i == s1_y && j == s1_x)
                        {
                            Map[s1_y,s1_x] = '●';
                        }

                        if (i == s2_y && j == s2_x)
                        {
                            Map[s2_y,s2_x] = '●';
                             
                        }

                        if (i == s3_y && j == s3_x)
                        {
                            Map[s3_y, s3_x] = '●';

                        }


                    }
                }



                Console.Clear();
                for (int i = 0; i<makeMap; i++)
                {
                    for (int j = 0; j<makeMap; j++)
                    {
                        Console.Write("{0}", Map[i, j]);
                    }
                    Console.WriteLine();


                }







            }






        }

    }
}
