using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcabcbb";
            HashSet<char> proc = new HashSet<char>();
            int n = s.Length;

            int right = -1;

            int output=0;

            for(int i=0;i<n;i++)
            {
                if (i != 0)
                {
                    proc.Remove(s[i - 1]);
                }
                else
                { }
                    while(right+1<n&& !proc.Contains(s[right+1]))
                    {
                        proc.Add(s[right + 1]);
                        right++;
                    }
                output = right - i + 1 > output ? right - i + 1 : output;
            }
                Console.WriteLine(output);
        }
    }
}
