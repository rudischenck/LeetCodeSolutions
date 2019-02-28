using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class ValidParenthesis
    {


        public bool IsValid(string s)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>()
            {
                { '}', '{' },
                { ']', '[' },
                { ')', '(' }
            };

            Stack<char> chars = new Stack<char>();

            foreach (var c in s)
            {
                if (dict.ContainsKey(c))
                {
                    var topElement = chars.TryPop(out char result) ? result : '#';

                    if (topElement != dict[c])
                    {
                        return false;
                    }
                }
                else
                {
                     chars.Push(c);
                }
            }

            return !chars.TryPeek(out var a);
        }


    }
}
