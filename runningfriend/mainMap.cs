using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;


namespace runningfriend
{
    public class mainMap
    {
        public void drawMap()
        {
            //랜덤 인스턴스 생성
            Random rand = new Random();

            //좌표 거리 계산 클래스 선언
            distanceResult distanceCal = new distanceResult();
            distanceSubAdd distanceEnemySubAdd = new distanceSubAdd();
            int count = 0;
            //적과의 거리 및 움직인 카운트 선언
            int the_distance_between_user_and_the_enemy = 0;
            int enemyMoveCount = 0;
            int[] testDistance = new int[999];

            int[] wallY = new int[999];
            int[] wallX = new int[999];

            //int gameOverCount = 0;
            //유저 맵 초기화 입력값 받기
            Console.WriteLine("세로 값을 입력해주세요.");
            string userInputY = Console.ReadLine();
            Console.WriteLine("가로 값을 입력해주세요.");
            string userInputX = Console.ReadLine();

            //정수형으로 변환
            int.TryParse(userInputY, out int mapAreaY);
            int.TryParse(userInputX, out int mapAreaX);

            //입력한 값으로 맵 만들기
            string[,] Map = new string[mapAreaY, mapAreaX];


            //유저 초기 랜덤 위치 초기화
            int userY = rand.Next(2, mapAreaY-3);
            int userX = rand.Next(2, mapAreaX-3);

            int[] enemyY_ = new int[999];
            int[] enemyX_ = new int[999];


            //적 초기 위치 변수 선언
            int enemyY = rand.Next(5, mapAreaY-5);
            int enemyX = rand.Next(5, mapAreaX-5);

            //배열에 출력할 값 입력
            for (int i = 0; i < mapAreaY; i++)
            {
                for (int j = 0; j < mapAreaX; j++)
                {
                    Map[i, j] = "　";

                    if (i == 0 || j == 0)
                    {
                        Map[i, j] = "■";
                    }
                    if (i == mapAreaY-1 || j == mapAreaX-1)
                    {
                        Map[i, j] = "■";
                    }
                    if (i == userY && j == userX)
                    {
                        Map[i, j] = "♥";
                    }
                }
            }
            //벽 생성
            for (int i = 0; i < 50; i++)
            {
                wallY[i]=rand.Next(2, mapAreaY-2);
                wallX[i]=rand.Next(2, mapAreaX-2);
                Map[wallY[i], wallX[i]] = "■";
            }

            //콘솔 위 한 번 출력
            for (int i = 0; i < mapAreaY; i++)
            {
                for (int j = 0; j < mapAreaX; j++)
                {
                    Console.Write("{0}", Map[i, j]);
                }
                Console.WriteLine();
            }


            while (true)
            {

                ConsoleKeyInfo UserInput = Console.ReadKey();
                //Console.Clear();
                if (UserInput.Key == ConsoleKey.W)
                {
                    if (userY > 1)
                    {
                        if (Map[(userY-1), userX] == "■")
                        {
                            //userY -= 1;
                            //Map[userY, userX] ="♥";
                            //Map[userY+1, userX] ="　";
                        }
                        else if (Map[(userY-1), userX] == "♣")
                        {
                            Console.WriteLine("클로버 문양 발견");
                            //userY -= 1;
                            //Map[userY, userX] ="♥";
                            //Map[userY+1, userX] ="　";
                        }
                        else
                        {
                            userY -= 1;
                            Map[userY, userX] ="♥";
                            Map[userY+1, userX] ="　";
                        }

                    }
                    else
                    {
                        userY = 1;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }//상단 이동
                else if (UserInput.Key == ConsoleKey.S)
                {
                    if (userY < mapAreaY-2)
                    {
                        if (Map[(userY+1), userX] == "■")
                        {
                            Console.WriteLine("적 문양 잘 만남");
                            //userY += 1;
                            //Map[userY, userX] ="♥";
                            //Map[userY-1, userX] ="　";
                        }
                        else if (Map[(userY+1), userX] == "♣")
                        {
                            Console.WriteLine("클로버 문양 발견");
                            //userY += 1;
                            //Map[userY, userX] ="♥";
                            //Map[userY-1, userX] ="　";
                        }
                        else
                        {
                            userY += 1;
                            Map[userY, userX] ="♥";
                            Map[userY-1, userX] ="　";
                        }

                    }
                    else
                    {
                        userY = mapAreaY-2;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }//하단 이동
                else if (UserInput.Key == ConsoleKey.A)
                {
                    if (userX > 1)
                    {
                        if (Map[userY, (userX-1)] == "■")
                        {
                            Console.WriteLine("벽 발견");
                            //userX -= 1;
                            //Map[userY, userX] ="♥";
                            //Map[userY, userX+1] ="　";
                        }
                        else if (Map[userY, (userX-1)] == "♣")
                        {
                            Console.WriteLine("클로버 발견");
                            //userX -= 1;
                            //Map[userY, userX] ="♥";
                            //Map[userY, userX+1] ="　";
                        }
                        else
                        {
                            userX -= 1;
                            Map[userY, userX] ="♥";
                            Map[userY, userX+1] ="　";
                        }
                    }
                    else
                    {
                        userX = 1;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }//좌측 이동
                else if (UserInput.Key == ConsoleKey.D)
                {
                    if (userX < mapAreaX-2)
                    {
                        if (Map[userY, (userX+1)] == "■")
                        {
                            Console.WriteLine("전투를 시작합니다.\n");
                            //userX += 1;
                            //Map[userY, userX] ="&";
                            //Map[userY, userX-1] ="　";
                        }
                        else if (Map[userY, (userX+1)] == "♣")
                        {
                            Console.WriteLine("카드 게임을 시작합니다.");
                            //userX += 1;
                            //Map[userY, userX] ="&";
                            //Map[userY, userX-1] ="　";
                        }
                        else
                        {
                            userX += 1;
                            Map[userY, userX] ="♥";
                            Map[userY, userX-1] ="　";
                        }

                    }
                    else
                    {
                        userX = mapAreaX-2;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }
                }//우측 이동
                else if (UserInput.Key == ConsoleKey.M)
                {
                    int monsterY = rand.Next(2, mapAreaY-2);
                    int monsterX = rand.Next(2, mapAreaX-2);
                    if (monsterY!=userY || monsterX!=userX)
                    {
                        Map[monsterY, monsterX] = "■";

                    }
                }//벽 생성
                else if (UserInput.Key == ConsoleKey.R)
                {
                    for (int i = 0; i < mapAreaY; i++)
                    {
                        for (int j = 0; j < mapAreaX; j++)
                        {
                            Map[i, j] = "　";

                            if (i == 0 || j == 0)
                            {
                                Map[i, j] = "■";
                            }
                            if (i == mapAreaY-1 || j == mapAreaX-1)
                            {
                                Map[i, j] = "■";
                            }
                            if (i == userY && j == userX)
                            {
                                Map[i, j] = "♥";
                            }
                        }
                    }
                }//리셋
                else if (UserInput.Key == ConsoleKey.C)
                {

                    for (int i = 0; i < 50; i++)
                    {
                        wallY[i]=rand.Next(2, mapAreaY-2);
                        wallX[i]=rand.Next(2, mapAreaX-2);
                        Map[wallY[i], wallX[i]] = "■";
                    }
                }

                //적 생성


                //moveCount += 1;
                //이제 적이 나를 찾아오는 ?

                //int testY = distanceCal.distanceXY(userY, enemyY);
                //Console.WriteLine("y값  = {0}",testY);
                //int testX = distanceCal.distanceXY(userX, enemyX);
                //Console.WriteLine("X값  = {0}", testX);
                //the_distance_between_user_and_the_enemy = distanceCal.distanceCalculation(distanceCal.distanceXY(userY, enemyY), distanceCal.distanceXY(userX, enemyX));
                //Console.WriteLine("적과 user의 거리 == {0} ", the_distance_between_user_and_the_enemy);




                enemyMoveCount +=1;
                if (enemyMoveCount >= 10)
                {
                    enemyMoveCount = 0;

                    while (true)
                    {
                        enemyY_[count]=rand.Next(4, mapAreaY-2);
                        enemyX_[count]=rand.Next(4, mapAreaX-2);
                        Map[enemyY_[count], enemyX_[count]] ="♧";

                        the_distance_between_user_and_the_enemy = distanceCal.distanceCalculation(distanceCal.distanceXY(userY, enemyY_[count]), distanceCal.distanceXY(userX, enemyX_[count]));
                        testDistance[count] = the_distance_between_user_and_the_enemy;
                        Console.WriteLine("적과 user의 거리 == {0} ", testDistance[count]);
                        Console.WriteLine("몬스터 생성 완료{0}", count);

                        count +=1;
                        break;
                    }

                }



                for (int i = 0; i <count; i++)
                {
                    int choice = rand.Next(0, 1);
                    if (choice == 0)
                    {
                        if (userY < enemyY_[i])
                        {
                            if (Map[(enemyY_[i]-1), enemyX_[i]] == "■" || Map[(enemyY_[i]-1), enemyX_[i]] == "♧")
                            {
                                //userY -= 1;
                                //Map[userY, userX] ="♥";
                                //Map[userY+1, userX] ="　";
                            }
                            else if(Map[(enemyY_[i]-1), enemyX_[i]] == "♥")
                            {
                                enemyY_[i] -= 1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i]+1, enemyX_[i]] ="　";
                                Console.WriteLine("GameOver");
                                break;
                            }
                            else
                            {
                                enemyY_[i] -= 1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i]+1, enemyX_[i]] ="　";
                            }
                        }
                        else if (userY > enemyY_[i])
                        {
                            if (Map[(enemyY_[i]+1), enemyX_[i]] == "■")
                            {/*pass*/ }
                            else
                            {
                                enemyY_[i] +=1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i]-1, enemyX_[i]] ="　";
                            }
                        }
                        //else if (userY - enemyY_[i] == 0)
                        //{
                        //    enemyY_[i] = 0;
                        //}

                        else if (userX < enemyX_[i])
                        {
                            if (Map[enemyY_[i], enemyX_[i]-1] == "■" || Map[enemyY_[i], enemyX_[i]-1] == "♧")
                            {
                                /*pass*/
                            }
                            else if (Map[enemyY_[i], enemyX_[i]-1] == "♥")
                            {
                                enemyX_[i] -= 1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i], enemyX_[i]+1] ="　";
                                Console.WriteLine("GameOver");

                            }
                            else
                            {
                                enemyX_[i] -= 1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i], enemyX_[i]+1] ="　";
                            }
                        }
                        else if (userX > enemyX_[i])
                        {
                            if (Map[(enemyY_[i]), enemyX_[i]+1] == "■"||Map[(enemyY_[i]), enemyX_[i]+1] == "♧")
                            {/*pass*/ }
                            else
                            {
                                enemyX_[i] +=1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i], enemyX_[i]-1] ="　";
                            }
                        }
                    }
                    else if (choice ==1)
                    {

                        //else if (userY - enemyY_[i] == 0)
                        //{
                        //    enemyY_[i] = 0;
                        //}

                        if (userX < enemyX_[i])
                        {
                            if (Map[enemyY_[i], enemyX_[i]-1] == "■")
                            {/*pass*/ }
                            else
                            {
                                enemyX_[i] -= 1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i], enemyX_[i]+1] ="　";
                            }
                        }
                        else if (userX > enemyX_[i])
                        {
                            if (Map[(enemyY_[i]), enemyX_[i]+1] == "■")
                            {/*pass*/ }
                            else
                            {
                                enemyX_[i] +=1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i], enemyX_[i]-1] ="　";
                            }
                        }
                        else if (userY < enemyY_[i])
                        {
                            if (Map[(enemyY_[i]-1), enemyX_[i]] == "■")
                            {
                                //userY -= 1;
                                //Map[userY, userX] ="♥";
                                //Map[userY+1, userX] ="　";
                            }
                            else
                            {
                                enemyY_[i] -= 1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i]+1, enemyX_[i]] ="　";
                            }
                        }
                        else if (userY > enemyY_[i])
                        {
                            if (Map[(enemyY_[i]+1), enemyX_[i]] == "■")
                            {/*pass*/ }
                            else
                            {
                                enemyY_[i] +=1;
                                Map[enemyY_[i], enemyX_[i]] ="♧";
                                Map[enemyY_[i]-1, enemyX_[i]] ="　";
                            }
                        }
                    }

                    //else if (userX - enemyX_[i] == 0)
                    //{
                    //    enemyX_[i] = 0;
                    //}

                    Console.WriteLine(" y위치는 = {0} ,  x위치는 = {1}", enemyY_[i], enemyX_[i]);
                }
                //변화한 값들 다시 출력해주는 출력문
                Console.SetCursorPosition(0, 4);
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < mapAreaY; i++)
                {
                    for (int j = 0; j < mapAreaX; j++)
                    {
                        Console.Write("{0}", Map[i, j]);
                    }
                    Console.WriteLine();
                }
            }

        }

    }
}
