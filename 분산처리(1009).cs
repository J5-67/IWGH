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
            List<int> resultList = new List<int>();
            long result = 1;
            int a = 0;
            int b = 0;

            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                a = int.Parse(input[0]);
                b = int.Parse(input[1]);

                for (int k = 0; k < b; k++)
                {
                    result *= a;
                    result %= 10;
                }

                if (result == 0)
                {
                    result = 10;
                }

                resultList.Add((int)result);

                result = 1;
            }

            Console.Clear();

            for (int i = 0; i < resultList.Count; i++)
            {
                Console.WriteLine(resultList[i]);
            }
        }
    }
}
