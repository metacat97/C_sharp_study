using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgtest
{
    internal class Battle
    {

        public void battle(ref int Hp, ref int Damage)
        {
            Hp = Hp - Damage;

        }



    }
}
