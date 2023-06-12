using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230612_study
{
    public class MonsterBase
    {
        //캡슐화 -> 필드를 private로 처리해서 외부에서 접근 불가능하도록 하겠다는ㄴ 의미.
        // protected 는 상속 받은 자식 클래스에서는 쓸 수 있도록 하겠다는 뜻
        private string name;  
        private int hp;
        private int mp;
        private int damage;
        private int defence;
        private string type;


        public virtual void Initilize(string name, int hp, int mp, int damage, int defence, string type)
        {
            this.name = name;
            this.hp = hp;
            this.mp = mp;
            this.damage = damage;
            this.defence = defence;
            this.type = type;
        }

        //함수를 내려받아 쓰겠다는 것이 오버 라이딩   부모에서는 버츄얼이라 써주고 

        public virtual void Print_MonsterInfo()
        {
            Console.WriteLine("몬스터 {0} 정보", name);
            Console.WriteLine("HP {0}  MP {1}  type {2}",hp,mp,type);
            Console.WriteLine("damage {0} defence {1}",damage,defence);
            
        }
    }



}
