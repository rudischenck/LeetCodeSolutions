using System;
using System.Collections.Generic;
using System.Text;


    //Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.

namespace LeetCodeSolutions
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            string intString = x.ToString();
            string intStringReverse = "";
            for (int i = intString.Length - 1; i >= 0; i--)
            {
                intStringReverse += intString[i];
            }
            if (intString == intStringReverse)
            {
                return true;
            }
            return false;
        }
    }
}
