using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalScore = 0;

            for (int i = 0; i < 5; i++)
            {
                totalScore += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(totalScore);
        }
    }
}
