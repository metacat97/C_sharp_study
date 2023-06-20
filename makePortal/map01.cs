using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makePortal
{
    public class map01
    {
        public void makeMap1(ref int userY, ref int userX)
        {
             
            string[,] Map = new string[15, 15];
            int saveY = 12;
            int saveX = 6;
            int count = 0;

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Map[i, j] = "　";

                    if (i == 0 || j == 0)
                    {
                        Map[i, j] = "■";
                    }
                    if (i == 14 || j == 14)
                    {
                        Map[i, j] = "■";
                    }
                    if (i ==14 && j > 5 && j < 9)
                    {
                        Map[i, j] = "▣";
                    }
                    if (i ==13 && j > 5 && j < 9)
                    {
                        Map[i, j] = "▣";
                    }
                    if (i == 14 && j == 7)
                    {
                        Map[i, j] = "▽";
                    }
                    if(saveY == i && saveX == j )
                    {
                        Map[i, j] = "♥";
                    }

                }
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write("{0}", Map[i, j]);
                }
                Console.WriteLine();
            }

            while (true)
            {
                ConsoleKeyInfo UserInput = Console.ReadKey();

                if (UserInput.Key == ConsoleKey.W)
                {
                    if(saveY > 1)
                    {
                        if (Map[saveY-1, saveX] == "▣")
                        {
                            userY = saveY;
                            userX = saveX;
                            Map[saveY, saveX] ="　";
                            count += 1;
                            goto print;
                        }
                        else
                        {
                            saveY -= 1;
                            Map[saveY, saveX] ="♥";
                            Map[saveY+1, saveX] ="　";
                        }
                    }
                    else
                    {
                        saveY = 1;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }
                }
                else if (UserInput.Key == ConsoleKey.S)
                {
                    if (saveY < 13)
                    {
                        if (Map[saveY+1, saveX] == "▣")
                        {
                            userY = saveY;
                            userX = saveX;
                            Map[saveY, saveX] ="　";
                            count += 1;
                            goto print;
                        }
                        else
                        {
                            saveY += 1;
                            Map[saveY, saveX] ="♥";
                            Map[saveY-1, saveX] ="　";
                        }
                    }
                    else
                    {
                        saveY = 13;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }
                }
                else if (UserInput.Key == ConsoleKey.A)
                {
                    if (saveX > 1)
                    {
                        if (Map[saveY, saveX -1] == "▣")
                        {
                            userY = saveY;
                            userX = saveX;
                            Map[saveY, saveX] ="　";
                            count += 1;
                            goto print;
                        }
                        else
                        {
                            saveX -= 1;
                            Map[saveY, saveX] ="♥";
                            Map[saveY, saveX+1] ="　";
                        }
                    }
                    else
                    {
                        saveX = 1;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }
                }
                else if (UserInput.Key == ConsoleKey.D)
                {
                    if (saveX < 13)
                    {
                        if (Map[saveY, saveX+1] == "▣")
                        {
                            userY = saveY;
                            userX = saveX;
                            Map[saveY, saveX] ="　";
                            count += 1;
                            goto print;
                        }
                        else
                        {
                            saveX += 1;
                            Map[saveY, saveX] ="♥";
                            Map[saveY, saveX-1] ="　";
                        }
                    }
                    else
                    {
                        saveY = 13;
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }
                }
                print:
                Console.SetCursorPosition(0,21);
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        Console.Write("{0}", Map[i, j]);
                    }
                    Console.WriteLine();
                }
                if (count >1 || count != 0)
                {
                    break;
                }


            }




        }


    }

}
