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
            string[] expInput = Console.ReadLine().Split(' ');

            int questCount = int.Parse(input[0]);
            int activeStoneCount = int.Parse(input[1]);

            int[] stone = new int[questCount];
            long[] questExp = new long[expInput.Length];
            long totalExp = 0;

            for (int i = 0; i < questExp.Length; i++)
            {
                questExp[i] = int.Parse(expInput[i]);
            }

            Array.Sort(questExp);

            for (int i = 0; i < questCount; i++)
            {
                int currentActiveStone = i < activeStoneCount ? i : activeStoneCount;
                totalExp += questExp[i] * currentActiveStone;
            }

            Console.WriteLine(totalExp);
        }
    }
}
