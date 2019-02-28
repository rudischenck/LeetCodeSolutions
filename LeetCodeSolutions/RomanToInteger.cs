using System;
using System.Collections.Generic;
using System.Text;

    //Given a roman numeral, convert it to an integer.Input is guaranteed to be within the range from 1 to 3999.

namespace LeetCodeSolutions
{
    class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> key = new Dictionary<char, int>();
            key.Add('I', 1);
            key.Add('V', 5);
            key.Add('X', 10);
            key.Add('L', 50);
            key.Add('C', 100);
            key.Add('D', 500);
            key.Add('M', 1000);

            int number = 0;
            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if ((i + 1 <= s.Length - 1) && (key[s[i]] < key[s[i + 1]]))
                    {
                        number += (key[s[i + 1]] - key[s[i]]);
                        i++;
                    }
                    else
                    {
                        number += key[s[i]];
                    }
                }
            }
            return number;
        }
    }
}
