using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230621_study
{
    public class Button : Clickable , IDamagable
    {
        
        public override void ClickThisObject(bool isClick_)
        {
            base.ClickThisObject(isClick_);
        }
        
        public void Damaged(int danage)
        {
            throw new NotImplementedException();
        }

        public void TestFunc()
        {
            Console.WriteLine("함수 테스트");
        }

    }
}
