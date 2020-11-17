using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.LengthOfLongestSubstringAlgorithm
{
    public static class LengthOfLongestSubstringSolution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            // record the characters that appear.
            HashSet<Char> oldCharContainer = new HashSet<char>();

            int n = s.Length;
            // right point, the initial value is -1, equivalent to no move
            int rk = -1, result = 0;
            for (int i = 0; i < n; i++)
            {
                if (i != 0)
                {
                    // the left pointer moves one space to the right to remove a character
                    oldCharContainer.Remove(s.ElementAt(i - 1));
                }

                while (rk + 1 < n && !oldCharContainer.Contains(s.ElementAt(rk + 1)))
                {
                    // keep moving the right pointer
                    oldCharContainer.Add(s.ElementAt(rk + 1));
                    rk++;
                }
                // the characters I through Rk are an extremely long non-repeating character substring
                Console.WriteLine("");
                foreach (var item in oldCharContainer)
                {
                    Console.Write(item + ",");
                }
                result = Math.Max(result, rk - i + 1);
            }

            return result;
        }
    }
}