using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokergame
{
    public class change
    {
        public  void AddSub(ref List<string> list)
        {
            List<string> temp = new List<string>();

            int userNumber1 = int.Parse(Console.ReadLine());
            int userNumber2 = int.Parse(Console.ReadLine());


            temp.Add(list[5]);
            temp.Add(list[6]);

            list[userNumber1-1] = temp[0];
            list[userNumber2-1] = temp[1];
            #region 노력했던흔적
            //temp.Add(list[5]);
            //Console.WriteLine("템프에 {0} 값이 담겼습니다.", temp[0]);

            //temp.Add(list[6]);
            //Console.WriteLine("템프에 {0} 값이 담겼습니다.", temp[1]);

            //list.RemoveAt(list.Count-1);
            //list.RemoveAt(list.Count-2);

            //list.RemoveAt(userNumber1-1);
            //Console.WriteLine("user넘버는 {0}",userNumber1);
            //Console.WriteLine("<---After User Card--->");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine("│ {0}    =====", list[i]);
            //}


            //list.RemoveAt(userNumber2-2);
            //Console.WriteLine("user넘버는 {0}", userNumber2);

            //Console.WriteLine("<---After User Card--->");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine("│ {0}    =====", list[i]);
            //}


            //list.Insert(userNumber1-1, temp[0]);
            //Console.WriteLine("{0}번째에 {1}값이 담겨야 합니다.", userNumber1, temp[0]);
            //Console.WriteLine("<---After User Card--->");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine("│ {0}    =====", list[i]);
            //}


            //list.Insert(userNumber2-2, temp[1]);
            //Console.WriteLine("{0}번째에 {1}값이 담겨야 합니다.", userNumber2, temp[1]);
            //Console.WriteLine("<---After User Card--->");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine("│ {0}    =====", list[i]);
            //}
            #endregion;
        }
        public void OneAddSub(ref List<string> list)
        {
            List<string> temp = new List<string>();

            int userNumber1 = int.Parse(Console.ReadLine());
            int userNumber2 = int.Parse(Console.ReadLine());


            temp.Add(list[5]);
            temp.Add(list[6]);

            list[userNumber1-1] = temp[0];
            list[userNumber2-1] = temp[1];
            
        }
    }
}
