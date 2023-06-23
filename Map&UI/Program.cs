using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI ui01 = new UI();
            ui01.MakeUI();
            Map map01 = new Map();
            map01.IniMap();
            map01.DrawMap();

        }
    }
}
