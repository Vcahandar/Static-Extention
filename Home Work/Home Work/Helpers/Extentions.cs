using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.Helpers
{
    public static class Extentions
    {
        public static int GetNumberFactorial(this int num)
        {
            int fact = 1;
            for (int i = 1; i < num; i++)
            {
                fact = fact * i;

            }
            return fact;

        }

        public static double GetPower(this int num, int pow)
        {
           
            var result = Math.Pow(num, pow);


            return result;

        }






    }
}
