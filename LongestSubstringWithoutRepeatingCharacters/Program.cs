using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate Random String
            #region
            char start = 'a';
            char[] table = new char[26];
            for(int i=0;i<table.Length;i++)
            {
                table[i] = start;
                start++;
            }

            Console.Write("Random String Length: ");
            int sLength = Convert.ToInt32(Console.ReadLine());

            Random r1 = new Random();
            List<Char> Geneated = new List<char>();
            for(int i=0;i<sLength;i++)
            {
                Geneated.Add(table[r1.Next(0, 26)]);
            }
            #endregion

            string s =new string(Geneated.ToArray());

            Console.WriteLine($"Generated random string: {s}");
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
                Console.WriteLine($"Longest substring without repeating characters: {output}");
        }
    }
}
