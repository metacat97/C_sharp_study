using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace _230612_study
{
    //- 몬스터 이름, HP, MP , damage, defence, 몬스터 타입
    // 위에 정의된 값을 출력하는 함수를 클래스 내부에 구현할 것 .
    public  class Troll : MonsterBase
    {
        public override void Initilize(string name, int hp, int mp,
            int damage, int defence, string type)
        {
            base.Initilize(name, hp, mp, damage, defence, type);

        }


        public override void Print_MonsterInfo()
        {
            base.Print_MonsterInfo();
        }
        



    }






}
