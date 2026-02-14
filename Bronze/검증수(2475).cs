using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result += int.Parse(input[i]) * int.Parse(input[i]);
            }

            Console.WriteLine(result % 10);
        }
    }
}
