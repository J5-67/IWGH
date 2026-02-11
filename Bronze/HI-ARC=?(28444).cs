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
            string[] input = Console.ReadLine().Split(' ');

            int H = int.Parse(input[0]);
            int I = int.Parse(input[1]);
            int A = int.Parse(input[2]);
            int R = int.Parse(input[3]);
            int C = int.Parse(input[4]);

            Console.WriteLine((H * I) - (A * R * C));
        }
    }
}
