using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int hour = int.Parse(input[0]);
            int minute = int.Parse(input[1]);

            int time = 60 * (hour - 9) + minute;

            Console.WriteLine(time);
        }
    }
}
