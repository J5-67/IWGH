using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};
            int[] weekday = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            string[] input = Console.ReadLine().Split(' ');
            int month = int.Parse(input[0]);
            int day = int.Parse(input[1]);

            int result = 0;

            for (int i = 1; i < month; i++)
            {
                result += weekday[i];
            }

            result += day;

            Console.WriteLine(week[result % 7]);
        }
    }
}
