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
            int carrotSize = 0;
            int a = 0;
            int b = 0;
            int temp = 0;
            int same = 0;
            int[] noseSize = new int[15];

            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < 15; i++)
            {
                noseSize[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < 14; i++)
            {
                a = noseSize[i];
                b = noseSize[i + 1];
                temp = temp > a ? temp : a;
                temp = temp > b ? temp : b;

                carrotSize = temp;
            }

            for (int i = 0; i < noseSize.Length; i++)
            {
                if (carrotSize == noseSize[i])
                {
                    temp = i;
                    same++;
                }
            }

            if (temp < noseSize.Length - 1)
            {
                carrotSize++;
            }
            else if (same > 1)
            {
                carrotSize++;
            }

            Console.WriteLine(carrotSize);
        }
    }
}
