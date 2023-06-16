using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

 
            string[,] Map = new string[15, 15];

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
start:

            #region roop_start
            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();

                Console.Clear();
                if (userInput.Key == ConsoleKey.R)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            //if (Map[i, j]== "1")
                            //{

                            //}
                            if (true)
                            {
                                Map[i, j] = "　";
                            }

                            if (i == 0 || j == 0)
                            {
                                Map[i, j] = "■";
                            }
                            if (i == 14 || j == 14)
                            {
                                Map[i, j] = "■";
                            }
                        }
                    }
                    goto start;
                }
                else if (userInput.Key == ConsoleKey.M)
                {

                    int num_y = rand.Next(1, 13);
                    int num_x = rand.Next(1, 13);

                    int num_y1 = rand.Next(1, 13);
                    int num_x1 = rand.Next(1, 13);

                    int num_y2 = rand.Next(1, 13);
                    int num_x2 = rand.Next(1, 13);

                    Map[num_y, num_x] = "1";
                    Map[num_y1, num_x1] = "1";
                    Map[num_y2, num_x2] = "1";

                }
                else if (userInput.Key == ConsoleKey.RightArrow)
                {
                    int temp = 0;
                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < 13; j++)
                        {
                            if (Map[i, j]== "1")
                            {
                                Map[i, j] = "　";

                                if(Map[i, 13] == "　")
                                {
                                    Map[i, 13] = "1";
                                }
                                else if (Map[i, 13] != "　")
                                {
                                    int.TryParse(Map[i, 13], out temp);
                                    temp += 1;
                                    Map[i, 13] = Convert.ToString(temp);

                                }
                            }

                        }
                    }
                }
                else if (userInput.Key == ConsoleKey.DownArrow)
                {
                    int temp = 0;
                    for (int i = 0; i < 13; i++)
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            if (Map[i, j]== "1")
                            {
                                Map[i, j] = "　";

                                if (Map[13, j] == "　")
                                {
                                    Map[13, j] = "1";
                                }
                                else if (Map[13, j] != "　")
                                {
                                    int.TryParse(Map[13, j], out temp);
                                    temp += 1;
                                    Map[13, j] = Convert.ToString(temp);

                                }
                            }

                        }
                    }
                }




                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        Console.Write("{0,2}", Map[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            #endregion




        }
    }
}
