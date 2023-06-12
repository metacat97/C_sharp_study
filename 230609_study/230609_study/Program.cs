using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _230609_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); ;
            int[] lottos = new int[6];
            random.Next(1,10);

            for (int i= 0; i<lottos.Length; i++)
            {
                lottos[i] = random.Next(1,45);
            }

            foreach(int lotto_ in lottos)
            {
                Thread.Sleep(1000);
                Console.Write("[ {0} ]", lotto_);
            }
            Console.WriteLine();

        }

        //static void PrintfMyArray(int[,] array_)
        //{
        //    for (int y =0; y<5; y++) 
        //    {
        //        for (int x = 0; x < 5; x++)
        //        {
        //            Console.Write("{0}", array_[y, x]);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}



    }
}


    //    static void Desc001()
    //    {
    //        Console.WriteLine("Hello World\n");
    //        string userInput1 = default;
    //        string userInput2 = default;

    //        int number = default;
    //        float f_number = default;

    //        int userNumber1 = default;
    //        int userNumber2 = default;



    //        // 여기서 입력 받음
    //        userInput1 = Console.ReadLine();
    //        userInput2 = Console.ReadLine();

    //        //입력받은 것을 숫자로 변환
    //        //userNumber1 = int.Parse(userInput1);
    //        //userNumber2 = int.Parse(userInput2);

    //        //System.Convert.ToInt32(userNumber1);
    //        //System.Convert.ToInt32(userNumber2);


    //        //int.TryParse(userInput1, out userNumber1);
    //        //int.TryParse(userInput2, out userNumber2);


    //        //출력
    //        Console.WriteLine("입력받은 내용을 출력하고 싶어 ->{0} + {1} = {2} \n\n",
    //            userNumber1, userNumber2, userNumber1 + userNumber2);
    //    }
    //}

