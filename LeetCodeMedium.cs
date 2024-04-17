using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group07_FinalProject
{
    public class LeetCodeMedium
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }

            long dvd = Math.Abs((long)dividend);
            long dvs = Math.Abs((long)divisor);
            int result = 0;

            for (int bit = 31; bit >= 0; bit--)
            {
                if (dvd >= (dvs << bit))
                {
                    result += 1 << bit;
                    dvd -= dvs << bit;
                }
            }

            return (dividend > 0) == (divisor > 0) ? result : -result;
        }
    }
}