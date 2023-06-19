using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230619_study
{
    public partial class Dog : MonsterBase
    {

        public void PrintM()
        {
            this.name = "강아지";
            base.PrintInfos();
        }
    }
}
