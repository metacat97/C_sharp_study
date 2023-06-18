using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_0._01
{
    public class Battle
    {
        public void battle(ref int Hp, ref int Damage)
        {
            Hp = Hp - Damage;

        }

        //public void Desc()
        //{
        //    //Battle fight = new Battle();
        //    //Orc orcMonster = new Orc();
        //    //orcMonster.Initilize("오크", 30, 5);
        //    //int userHp = 50;
        //    //int userDamage = 10;
        //    //while (true)
        //    //{
        //    //    if (userHp == 0)
        //    //    {
        //    //        Console.WriteLine("사용자의 체력이 {0}이 되어 게임을 종료합니다", 
        //    //            userHp);
        //    //        break;
        //    //    }
        //    //    else if (orcMonster.hp == 0)
        //    //    {
        //    //        Console.WriteLine("{0}의 체력이 {1}이 되어 싸움에서 승리하였습니다.",
        //    //            orcMonster.name, orcMonster.hp);
        //    //        break;
        //    //    }

        //    //    fight.battle(ref userHp, ref orcMonster.damage);
        //    //    Console.WriteLine("현재 유저의 hp 는 ={0},  대미지 = {1}", 
        //    //        userHp, orcMonster.damage);

        //    //    fight.battle(ref orcMonster.hp, ref userDamage);
        //    //    Console.WriteLine("현재 {0}의 hp 는 ={1},  대미지 = {2}", 
        //    //        orcMonster.name, orcMonster.hp, userDamage);

        //    //}
        //}

    }
}
