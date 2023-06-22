using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocketmon
{
    public class Orc : monsterBase
    {
        public override void Initilize(string name, int hp, int damage)
        {
            base.Initilize(name, hp, damage);

        }
        public override void Print_MonsterInfo()
        {
            base.Print_MonsterInfo();

            //Console.WriteLine("뭔가 작업을 했다.");
            Console.WriteLine("");
        }
    }
}
