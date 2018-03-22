﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    public class PalindromeString
    {
        string word;

        public PalindromeString(string strword)
        {
            word = strword;
        }

        public bool CheckPalindrome(string word)
        {
            int i = 0;
            int j = word.Length - 1;
            bool IsPalindrome = true;

            while (i < j)
            {
                if (word[i] != word[j])
                    IsPalindrome = false;

                i++;
                j--;
            }

            return IsPalindrome;
        }


    }
}