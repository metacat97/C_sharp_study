using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makePortal
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userY1 = 8;
            int userX1 = 8;

            int userY2 = 8;
            int userX2 = 8;
            map01 draw1 = new map01(); 
            map02 draw2 = new map02();
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                draw2.makeMap2(ref userY2, ref userX2);
                Console.WriteLine();
                draw1.makeMap1(ref userY1, ref userX1);
            }
        }
    }
}
