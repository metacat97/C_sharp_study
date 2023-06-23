using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_23
{
    public class Map
    {
        public int MapWidth { get; protected set; }
        public int MapLength { get; protected set; }

        int[,] field = default;




        public Map()
        {
            MapWidth = 50;
            MapLength = 20;

            field = new int[MapLength, MapWidth];
        }




        public void IniMap()
        {

            for (int vertical = 0; vertical < MapLength; vertical++)
            {
                for (int horizon = 0; horizon < MapWidth; horizon++)
                {
                    field[vertical, horizon] = 0;
                    
                }
            }
        }




        public void DrawMap()
        {
            //Console.SetCursorPosition(1, 1);
            for (int j = 0; j < MapLength; j++)
            {
                for (int i = 0; i < MapWidth; i++)
                {
                    Console.SetCursorPosition(i+8, j+3);
                    Console.Write("{0}", field[j,i]);
                }
                Console.WriteLine();
            }
        }

    }

}
