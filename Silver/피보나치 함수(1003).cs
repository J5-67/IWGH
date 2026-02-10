using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int input = int.Parse(Console.ReadLine());
            int[] numArray = new int[input];
            int[] zero = new int[41];
            int[] one = new int[41];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            zero[0] = 1; one[0] = 0;
            zero[1] = 0; one[1] = 1;

            for (int i = 2; i <= 40; i++)
            {
                zero[i] = zero[i - 1] + zero[i - 2];
                one[i] = one[i - 1] + one[i - 2];
            }

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(zero[numArray[i]] + " " + one[numArray[i]]);
            }

        }
    }
}
