using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            BigInteger money = BigInteger.Parse(input[0]);
            BigInteger unit = BigInteger.Parse(input[1]);

            BigInteger share = money / unit;
            BigInteger remainder = money % unit;

            Console.WriteLine(share);
            Console.WriteLine(remainder);
        }
    }
}
