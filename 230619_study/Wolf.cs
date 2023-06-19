using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230619_study
{
    public class Wolf : MonsterBase
    {

        public override void PrintInfos()
        {
            this.name = "사자";
            base.PrintInfos();
        }

    }
}
