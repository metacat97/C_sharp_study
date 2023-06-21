using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace runningfriend
{
    public class distanceResult
    {

       
        public int distanceCalculation(int distanceY, int distanceX)
        {
            int resultY = distanceY * distanceY;
            int resultX = distanceX * distanceX;
            int resultXY = resultY + resultX;

            return (int)Math.Sqrt(resultXY);
        } 
        public int distanceXY(int distance1, int distance2)
        {
            int result = distance1 - distance2;
            return result;
        }

    }
}
