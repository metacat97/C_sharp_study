using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _230619_study
{
    public static class MyTools
    {
        public static void DogPrint(this Dog mydog)// 붙이고 싶은거에 붙여주자
        {
            mydog.PrintInfos();
        }


        public static int Plus(this int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }
        public static int PlusAndPrint(this int firstValue, int secondValue )
        {
            Console.WriteLine("{0} + {1} = {2}",firstValue, secondValue, firstValue+secondValue);
            return firstValue + secondValue;
             
        }

    }
}
