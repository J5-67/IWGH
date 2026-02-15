using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToUpper();
            int[] counts = new int[26];
            int maxCount = -1;
            char result = '?';

            foreach (char c in input)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    counts[c - 'A']++;
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if (counts[i] > maxCount)
                {
                    maxCount = counts[i];
                    result = (char)(i + 'A');
                }
                else if (counts[i] == maxCount)
                {
                    result = '?';
                }
            }

            Console.WriteLine(result);
        }
    }
}
