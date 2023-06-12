using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230612_study
{
    public class SecretCode
    {
        
        private int pcCode;
        public  int myCode;
        public char code;

        public SecretCode()
        {
            Random random = new Random();
            pcCode = random.Next(65,90); 
        }

        public void thinkNumber()
        {

            while (true)
            {
                Console.WriteLine("A~Z 사이의 값을 입력해주세요.");
                Console.WriteLine("");
                char.TryParse(Console.ReadLine(),out code); //TryParse는 강제 형변환
                Console.WriteLine("pcCode [{0} ]", pcCode);
                
                
                if (code == pcCode)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Console.WriteLine("유저{0}", code);
                    break;
                }
                else if (code < pcCode)
                {
                    Console.WriteLine("유저{0}", code);

                    Console.WriteLine("더 많습니다");
                }
                else if (code > pcCode)
                {
                    Console.WriteLine("유저{0}", code);

                    Console.WriteLine("더 적습니다");

                }

            }


        }
    }

}
