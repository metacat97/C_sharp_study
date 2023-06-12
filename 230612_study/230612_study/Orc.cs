using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230612_study
{
    public class Orc : MonsterBase
    {

        public override void Initilize(string name, int hp, int mp, 
            int damage, int defence, string type)
        {
            base.Initilize(name, hp, mp, damage, defence, type);
          
        }


        public override void Print_MonsterInfo()
        {
            base.Print_MonsterInfo();

            //Console.WriteLine("뭔가 작업을 했다.");
            Console.WriteLine("");
        }


    }
}
