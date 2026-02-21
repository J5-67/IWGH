using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> answers = new List<string>();

            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int A = int.Parse(input[1]);
            int B = int.Parse(input[2]);
            int C = int.Parse(input[3]);
            int D = int.Parse(input[4]);
            int E = int.Parse(input[5]);
            int F = int.Parse(input[6]);
            int G = int.Parse(input[7]);
            int H = int.Parse(input[8]);
            int X;
            int Y;
            int Z;

            for (X = 0; X <= N; X++)
            {
                for (Y = 0; Y <= N - X; Y++)
                {
                    Z = N - X - Y;

                    if ((A * X + B * Y + C * Z == D) && (E * X + F * Y + G * Z == H))
                    {
                        answers.Add($"{X} {Y} {Z}");
                    }
                }
            }

            if (answers.Count == 1)
            {
                Console.WriteLine(0);
                Console.WriteLine(answers[0]);
            }
            else if (answers.Count > 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }
        }
    }
}
