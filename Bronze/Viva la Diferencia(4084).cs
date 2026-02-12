using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> answer = new List<int>();
            string input = Console.ReadLine();
            int count = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            while (input != "0 0 0 0")
            {
                string[] inputArr = input.Split(' ');
                a = int.Parse(inputArr[0]);
                b = int.Parse(inputArr[1]);
                c = int.Parse(inputArr[2]);
                d = int.Parse(inputArr[3]);

                count = 0;

                while (!(a == b && b == c && c == d))
                {
                    int temp = a;
                    a = Math.Abs(a - b);
                    b = Math.Abs(b - c);
                    c = Math.Abs(c - d);
                    d = Math.Abs(d - temp);
                    count++;
                }

                answer.Add(count);

                input = Console.ReadLine();
            }

            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
