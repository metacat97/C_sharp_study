using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pocketmon
{
    public class mainMap
    {
        public void drawMap()
        {
            //랜덤 인스턴스 생성
            Random rand = new Random();
            //메인 맵 초기 크기 선언
            int yFirst_Map_Area = 40;
            int xFirst_Map_Area = 80;
            //유저 위치 선언
            int user_y_Position = 20;
            int user_x_Position = 40;
            //퀘스트NPC 생성 위치 
            int questNpc_y_Position = 20;
            int questNpc_x_Position = 37;
            //맵 배열 만들기
            string[,] Map = new string[yFirst_Map_Area, xFirst_Map_Area];
            //배틀 변수 선언
            Battle fight = new Battle();
            Orc orcMonster = new Orc();
            int userHp = 100;
            int userDamage = 10;
            int battleCounting = 0;
            //퀘스트 관련 선언
            Quest accept = new Quest();
            int questState = 0;
            int questCount = 0;

            //배열에 출력할 값 입력
            for (int i = 0; i < yFirst_Map_Area; i++)
            {
                for (int j = 0; j < xFirst_Map_Area; j++)
                {
                    Map[i, j] = "　";
                    if (i == 0 || j == 0)
                    {
                        Map[i, j] = "■";
                    }
                    if (i == yFirst_Map_Area-1 || j == xFirst_Map_Area-1)
                    {
                        Map[i, j] = "■";
                    }
                    if (i >5 && i < 17 && j > 53 && j<74)
                    {
                        Map[i, j] = "▲";
                    }
                    if (i == user_y_Position && j == user_x_Position)
                    {
                        Map[i, j] = "♥";
                    }
                    if (i == questNpc_y_Position && j == questNpc_x_Position)
                    {
                        Map[i, j] = "＠";
                    }
                }
            }
            //콘솔 위 한 번 출력
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < yFirst_Map_Area; i++)
            {
                for (int j = 0; j < xFirst_Map_Area; j++)
                {
                    if (i >5 && i < 17 && j > 53 && j<74)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;    
                    }
                    if (i == 0 || j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    if (i == yFirst_Map_Area-1 || j == xFirst_Map_Area-1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    if (i == user_y_Position && j == user_x_Position)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (i == questNpc_y_Position && j == questNpc_x_Position)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.Write("{0}", Map[i, j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }//처음 출력 끝나는 부분

            //main while 반복문 시작
            while (true)
            {
                ConsoleKeyInfo UserInput = Console.ReadKey();
                //Console.Clear();
                if (UserInput.Key == ConsoleKey.W)
                {
                    if (user_y_Position > 1)
                    {
                        if (Map[(user_y_Position-1), user_x_Position] == "■")
                        {
                            
                        }
                        else if (Map[(user_y_Position-1), user_x_Position] == "＠")
                        {
                            Console.WriteLine("클로버 문양 발견");
                            accept.questStart(ref questState,ref questCount, 25, 30);
                            //user_y_Position -= 1;
                            //Map[user_y_Position, user_x_Position] ="♥";
                            //Map[user_y_Position+1, user_x_Position] ="　";
                        }
                        else if (user_y_Position >5 && user_y_Position < 17 && user_x_Position > 53 && user_x_Position<74)
                        {

                            battleCounting = rand.Next(1, 100);
                            if (battleCounting > 1 && battleCounting < 37)
                            {
                                Console.Clear();
                                Console.WriteLine("{0}", battleCounting);
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
                                        questCount += 1;
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

                            }
                            
                            user_y_Position -= 1;
                            Map[user_y_Position, user_x_Position] ="♥";
                            Map[user_y_Position+1, user_x_Position] ="※";

                        }
                        else
                        {
                            user_y_Position -= 1;
                            Map[user_y_Position, user_x_Position] ="♥";
                            Map[user_y_Position+1, user_x_Position] ="　";
                        }
                        
                        


                    }
                    else
                    {
                        user_y_Position = 1;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }//상단 이동
                else if (UserInput.Key == ConsoleKey.S)
                {
                    if (user_y_Position < yFirst_Map_Area-2)
                    {
                        if (Map[(user_y_Position+1), user_x_Position] == "■")
                        {
                            Console.WriteLine("적 문양 잘 만남");
                            //user_y_Position += 1;
                            //Map[user_y_Position, user_x_Position] ="♥";
                            //Map[user_y_Position-1, user_x_Position] ="　";
                        }
                        else if (Map[(user_y_Position+1), user_x_Position] == "＠")
                        {
                            Console.WriteLine("클로버 문양 발견");
                            accept.questStart(ref questState, ref questCount, 25, 30);

                            //user_y_Position += 1;
                            //Map[user_y_Position, user_x_Position] ="♥";
                            //Map[user_y_Position-1, user_x_Position] ="　";
                        }
                        else if (user_y_Position >5 && user_y_Position < 17 && user_x_Position > 53 && user_x_Position<74)
                        {

                            battleCounting = rand.Next(1, 100);
                            if (battleCounting > 1 && battleCounting < 37)
                            {
                                Console.Clear();
                                Console.WriteLine("{0}", battleCounting);
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
                                        questCount += 1;
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

                            }

                            user_y_Position += 1;
                            Map[user_y_Position, user_x_Position] ="♥";
                            Map[user_y_Position-1, user_x_Position] ="※";

                        }
                        else
                        {
                            user_y_Position += 1;
                            Map[user_y_Position, user_x_Position] ="♥";
                            Map[user_y_Position-1, user_x_Position] ="　";
                        }

                    }
                    else
                    {
                        user_y_Position = yFirst_Map_Area-2;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }//하단 이동
                else if (UserInput.Key == ConsoleKey.A)
                {
                    if (user_x_Position > 1)
                    {
                        if (Map[user_y_Position, (user_x_Position-1)] == "■")
                        {
                            Console.WriteLine("벽 발견");
                            //user_x_Position -= 1;
                            //Map[user_y_Position, user_x_Position] ="♥";
                            //Map[user_y_Position, user_x_Position+1] ="　";
                        }
                        else if (Map[user_y_Position, (user_x_Position-1)] == "＠")
                        {
                            Console.WriteLine("클로버 발견");
                            accept.questStart(ref questState, ref questCount, 25, 30);

                            //user_x_Position -= 1;
                            //Map[user_y_Position, user_x_Position] ="♥";
                            //Map[user_y_Position, user_x_Position+1] ="　";

                        }
                        else if (user_y_Position >5 && user_y_Position < 17 && user_x_Position > 53 && user_x_Position<74)
                        {

                            battleCounting = rand.Next(1, 100);
                            if (battleCounting > 1 && battleCounting < 37)
                            {
                                Console.Clear();
                                Console.WriteLine("{0}", battleCounting);
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
                                        questCount += 1;
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

                            }

                            user_x_Position -= 1;
                            Map[user_y_Position, user_x_Position] ="♥";
                            Map[user_y_Position, user_x_Position+1] ="※";

                        }
                        else
                        {
                            user_x_Position -= 1;
                            Map[user_y_Position, user_x_Position] ="♥";
                            Map[user_y_Position, user_x_Position+1] ="　";
                        }
                    }
                    else
                    {
                        user_x_Position = 1;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }//좌측 이동
                else if (UserInput.Key == ConsoleKey.D)
                {
                    if (user_x_Position < xFirst_Map_Area-2)
                    {
                        if (Map[user_y_Position, (user_x_Position+1)] == "■")
                        {
                            Console.WriteLine("전투를 시작합니다.\n");
                            //user_x_Position += 1;
                            //Map[user_y_Position, user_x_Position] ="&";
                            //Map[user_y_Position, user_x_Position-1] ="　";
                        }
                        else if (Map[user_y_Position, (user_x_Position+1)] == "@")
                        {
                            Console.WriteLine("카드 게임을 시작합니다.");
                            accept.questStart(ref questState, ref questCount, 25, 33);

                            //user_x_Position += 1;
                            //Map[user_y_Position, user_x_Position] ="&";
                            //Map[user_y_Position, user_x_Position-1] ="　";
                        }
                        else if (user_y_Position >5 && user_y_Position < 17 && user_x_Position > 53 && user_x_Position<74)
                        {

                            battleCounting = rand.Next(1, 100);
                            if (battleCounting > 1 && battleCounting < 37)
                            {
                                Console.Clear();
                                Console.WriteLine("{0}", battleCounting);
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
                                        questCount += 1;
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

                            }

                            user_x_Position += 1;
                            Map[user_y_Position, user_x_Position] ="♥";
                            Map[user_y_Position, user_x_Position-1] ="※";

                        }
                        else
                        {
                            user_x_Position += 1;
                            Map[user_y_Position, user_x_Position] ="♥";
                            Map[user_y_Position, user_x_Position-1] ="　";
                        }

                    }
                    else
                    {
                        user_x_Position = xFirst_Map_Area-2;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }
                }//우측 이동
                else if (UserInput.Key == ConsoleKey.R)
                {
                    for (int i = 0; i < yFirst_Map_Area; i++)
                    {
                        for (int j = 0; j < xFirst_Map_Area; j++)
                        {
                            Map[i, j] = "　";
                            if (i == 0 || j == 0)
                            {
                                Map[i, j] = "■";
                            }
                            if (i == yFirst_Map_Area-1 || j == xFirst_Map_Area-1)
                            {
                                Map[i, j] = "■";
                            }
                            if (i >5 && i < 17 && j > 53 && j<74)
                            {
                                Map[i, j] = "▦";
                            }
                            if (i == user_y_Position && j == user_x_Position)
                            {
                                Map[i, j] = "♥";
                            }
                            if (i == questNpc_y_Position && j == questNpc_x_Position)
                            {
                                Map[i, j] = "＠";
                            }
                        }
                    }
                }//맵 리셋

                


                //출력하는 부분
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < yFirst_Map_Area; i++)
                {
                    for (int j = 0; j < xFirst_Map_Area; j++)
                    {
                        if (i >5 && i < 17 && j > 53 && j<74)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        if (i == 0 || j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        if (i == yFirst_Map_Area-1 || j == xFirst_Map_Area-1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        if (i == user_y_Position && j == user_x_Position)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if (i == questNpc_y_Position && j == questNpc_x_Position)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                        Console.Write("{0}", Map[i, j]);
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }//while안에서 출력 끝나는 부분
                    Console.WriteLine("퀘스트 카운트 누적={0}  퀘스트 받았는지={1} ",questCount,questState);

            }//main while 끝나는 부분


        }

    }
}
