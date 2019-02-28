using System;
using System.Collections.Generic;

    //Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    //An input string is valid if:

    //Open brackets must be closed by the same type of brackets.
    //Open brackets must be closed in the correct order.
    //Note that an empty string is also considered valid

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
