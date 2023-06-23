using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_23
{
    public class UI
    {
        public void MakeUI() 
        {
            Console.SetWindowSize(104, 40);
            Console.WriteLine("┏───────────────────────────────────────────────────────────────┓");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┗───────────────────────────────────────────────────────────────┛");
            Console.SetCursorPosition(0, 28);
            Console.WriteLine("┏───────────────────────────────────────────────────────────────┓");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┃                                                               ┃");
            Console.WriteLine("┗───────────────────────────────────────────────────────────────┛");



            for(int j = 0; j < 15; j++) 
            {
                Console.SetCursorPosition(70, j);
                if(j == 0) 
                {
                    Console.WriteLine("┏───────────────────────────┓");
                }
                else if(j == 14) 
                {
                    Console.WriteLine("┗───────────────────────────┛");
                }
                else
                {
                    Console.WriteLine("┃                           ┃");
                }
            }

            //Console.SetCursorPosition(70, 0);
            //Console.WriteLine("┏───────────────────────────┓");
            //Console.SetCursorPosition(70, 1);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 2);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 3);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 4);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 5);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 6);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 7);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 8);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 9);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 10);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 11);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 12);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 13);
            //Console.WriteLine("┃                           ┃");
            //Console.SetCursorPosition(70, 14);
            //Console.WriteLine("┗───────────────────────────┛");



        }









    }
}
