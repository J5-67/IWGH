using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string answer = string.Empty;

            foreach (char c in input)
            {
                answer += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
            }

            Console.WriteLine(answer);
        }
    }
}
