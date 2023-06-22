using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocketmon
{
    public class monsterBase
    {
        public string name;
        public int hp;
        public int damage;

        public virtual void Initilize(string name, int hp, int damage)
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;
        }

        public virtual void Print_MonsterInfo()
        {
            Console.WriteLine("몬스터 {0} 정보", name);
            Console.WriteLine("HP {0} damage {1}  ", hp, damage);
        }
    }
}
