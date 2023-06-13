using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tictaeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pc = 0;
            int userInput = 0;
            
            
            int[] numbers = new int[9];
            Random random = new Random();



            //각 배열에 값 저장
            for (int i = 0; i < 9; i++)
           {
                numbers[i] = i+1;
           }
            // Console.WriteLine("{0}", numbers[3]);




            while (true)
            {
                //Console.Clear();

                Console.WriteLine("┌────────────┬─────────────┬────────────┐");
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("│      {0}            {1}              {2}     ", numbers[0], numbers[1], numbers[2]);
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("├────────────┼─────────────┼────────────┤");
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("│      {0}            {1}             {2}     ", numbers[3], numbers[4], numbers[5]);
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("├────────────┼─────────────┼────────────┤");
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("│      {0}            {1}             {2}   ", numbers[6], numbers[7], numbers[8]);
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("│            │             │            │");
                Console.WriteLine("└────────────┴─────────────┴────────────┘");



                //===========================================================================================================================


                int.TryParse(Console.ReadLine(), out userInput);



                if (userInput == 1)
                {
                    Console.WriteLine("유저가 누른 값 = {0}, 눌린 자리 = {1}", userInput, numbers[0]);
                    numbers[0] = 0;
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("유저가 누른 값 = {0}, 눌린 자리 = {1}", userInput, numbers[1]);
                    numbers[1] = 0;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("유저가 누른 값 = {0}, 눌린 자리 = {1}", userInput, numbers[2]);
                    numbers[2] = 0;
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("유저가 누른 값 = {0}, 눌린 자리 = {1}", userInput, numbers[3]);
                    numbers[3] = 0;
                }
                else if (userInput == 5)
                {
                    Console.WriteLine("유저가 누른 값 = {0}, 눌린 자리 =  {1}", userInput, numbers[4]);
                    numbers[4] = 0;
                }
                else if (userInput == 6)
                {
                    Console.WriteLine("유저가 누른 값 = {0}, 눌린 자리 = {1}", userInput, numbers[5]);
                    numbers[5] = 0;
                }
                else if (userInput == 7)
                {
                    Console.WriteLine("유저가 누른 값 = {0}, 눌린 자리 = {1}", userInput, numbers[6]);
                    numbers[6] = 0;
                }
                else if (userInput == 8)
                {
                    Console.WriteLine("유저가 누른 값 = {0}, 눌린 자리 =  {1}", userInput, numbers[7]);
                    numbers[7] = 0;
                }
                else if (userInput == 9)
                {
                    Console.WriteLine("유저가 누른 값 = {0}, 눌린 자리 = {1}", userInput, numbers[8]);
                    numbers[8] = 0;
                }
                else
                {
                    Console.WriteLine("제대로 입력해주세요");
                }



                //============================================================================================================================


                Thread.Sleep(500);

second:
                pc = random.Next(49, 57);

                if (pc == 49)
                {
                    if (numbers[0]==65)
                    {

                    }
                    Console.WriteLine("pc가 누른 값 = {0}, 눌린 자리 = {1}", pc, numbers[0]);

                    if (numbers[0] == 0 || numbers[0] == 'A')
                    {
                        goto second;
                    }

                    numbers[0] = 'B';
                }
                else if (pc == 50)
                {
                    Console.WriteLine("pc가 누른 값 = {0}, 눌린 자리 = {1}", pc, numbers[1]);

                    if (numbers[1] == 'B' || numbers[1] == 'A')
                    {
                        goto second;
                    }
                    numbers[1] = 'B';
                }
                else if (pc == 51)
                {
                    Console.WriteLine("pc가 누른 값 = {0}, 눌린 자리 = {1}", pc, numbers[2]);
                    if (numbers[2] == 'B' || numbers[2] == 'A')
                    {
                        goto second;
                    }
                    numbers[2] = 'B';
                }
                else if (pc == 52)
                {
                    Console.WriteLine("pc가 누른 값 = {0}, 눌린 자리 = {1}", pc, numbers[3]);
                    if (numbers[3] == 'B' || numbers[3] == 'A')
                    {
                        goto second;
                    }
                    numbers[3] = 'B';
                }
                else if (pc == 53)
                {
                    Console.WriteLine("pc가 누른 값 = {0}, 눌린 자리 =  {1}", pc, numbers[4]);
                    if (numbers[4] == 'B' || numbers[4] == 'A')
                    {
                        goto second;
                    }

                    numbers[4] = 'B';
                }
                else if (pc == 54)
                {
                    Console.WriteLine("pc가 누른 값 = {0}, 눌린 자리 = {1}", pc, numbers[5]);
                    if (numbers[5] == 'B' || numbers[5] == 'A')
                    {
                        goto second;
                    }

                    numbers[5] = 'B';
                }
                else if (pc == 55)
                {
                    Console.WriteLine("pc가 누른 값 = {0}, 눌린 자리 = {1}", pc, numbers[6]);
                    if (numbers[6] == 'B' || numbers[6] == 'A')
                    {
                        goto second;
                    }

                    numbers[6] = 'B';
                }
                else if (pc == 56)
                {
                    Console.WriteLine("pc가 누른 값 = {0}, 눌린 자리 =  {1}", pc, numbers[7]);
                    if (numbers[7] == 'B' || numbers[7] == 'A')
                    {
                        goto second;
                    }

                    numbers[7] = 'B';
                }
                else if (pc == 57)
                {
                    Console.WriteLine("pc가 누른 값 = {0}, 눌린 자리 = {1}", pc, numbers[8]);
                    if (numbers[8] == 'B' || numbers[8] == 'A')
                    {
                        goto second;
                    }

                    numbers[8] = 'B';
                }
                else
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                    //goto second;
                }


                Console.WriteLine();
                Console.WriteLine();




            }




































        }




    }
}
