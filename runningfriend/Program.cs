using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace runningfriend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mainMap draw = new mainMap();
            distanceResult distance = new distanceResult();

            draw.drawMap();

        }
    }
}
