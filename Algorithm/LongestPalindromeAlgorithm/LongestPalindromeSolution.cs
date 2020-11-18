using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    public static class LongestPalindromeSolution
    {
        public static string LongestPalindrome(string s)
        {
            if (s.Length < 2)
                return s;

            if (s.Length == 2)
                return s[0] == s[1] ? s : s[0].ToString();


            int left = 0, right = 0;
            string temp = string.Empty, result = string.Empty;
            while (right < s.Length)
            {
                if (!temp.Contains(s.ElementAt(right)))
                {
                    temp += s.ElementAt(right);
                }
                else
                {
                    int start = temp.IndexOf(s[right]);
                    string comstring = s.Substring(start, right - start + 1);
                    result = result.Length > comstring.Length + 1 ? result : comstring;
                    left++;
                }
                right++;
            }

            return result;
        }
    }
}
