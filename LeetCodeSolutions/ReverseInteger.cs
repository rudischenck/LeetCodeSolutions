using System;
using System.Collections.Generic;
using System.Text;

    //Given a 32-bit signed integer, reverse digits of an integer.

namespace LeetCodeSolutions
{
    class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x == 0) { return 0; }
            string numstr = x.ToString();

            bool isNegative = numstr[0] == '-';
            string newNum = isNegative ? "-" : "";
            for (int i = numstr.Length - 1; i >= (isNegative ? 1 : 0); i--)
            {
                newNum += numstr[i];
            }

            try
            {
                return int.Parse(newNum);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
