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
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                Console.WriteLine("CE");
                return;
            }

            if (input.StartsWith(@"""") && input.EndsWith(@""""))
            {
                string content = input.Substring(1, input.Length - 2);

                if (content.Length == 0)
                {
                    Console.WriteLine("CE");
                }
                else
                {
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("CE");
            }
        }
    }
}
