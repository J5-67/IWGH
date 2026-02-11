using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string[] input = Console.ReadLine().Split(' ');
        //    int N = int.Parse(input[0]);
        //    int M = int.Parse(input[1]);
        //    int numCheck = 0;
        //    string[] pokedex = new string[N];
        //    object[] test1 = new object[N];
        //    string[] exam = new string[M];
        //    object[] test2 = new object[M];

        //    for (int i = 0; i < N; i++)
        //    {
        //        pokedex[i] = Console.ReadLine();

        //        bool isNum = int.TryParse(pokedex[i], out numCheck);

        //        if (isNum)
        //        {
        //            test1[i] = numCheck;
        //        }
        //        else
        //        {
        //            test1[i] = pokedex[i];
        //        }
        //    }

        //    for (int i = 0; i < M; i++)
        //    {
        //        exam[i] = Console.ReadLine();

        //        bool isNum = int.TryParse(exam[i], out numCheck);

        //        if (isNum)
        //        {
        //            test2[i] = numCheck;
        //        }
        //        else
        //        {
        //            test2[i] = exam[i];
        //        }
        //    }

        //    for (int i = 0; i < test2.Length; i++)
        //    {
        //        if(test2[i].GetType().Name == "Int32")
        //        {
        //            int pokeNum = Convert.ToInt32(test2[i]);
        //            Console.WriteLine(test1[pokeNum - 1]);
        //        }
        //        else
        //        {
        //            for (int k = 0; k < test1.Length; k++)
        //            {
        //                if(test2[i].Equals(test1[k]))
        //                {
        //                    Console.WriteLine(k + 1);
        //                }
        //            }
        //        }
        //    }
        //}

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            string[] numToName = new string[N + 1];
            Dictionary<string, int> nameToNum = new Dictionary<string, int>();

            for (int i = 1; i <= N; i++)
            {
                string name = Console.ReadLine();
                numToName[i] = name;
                nameToNum[name] = i;
            }

            for (int i = 0; i < M; i++)
            {
                string query = Console.ReadLine();

                if (int.TryParse(query, out int num))
                {
                    Console.WriteLine(numToName[num]);
                }
                else
                {
                    Console.WriteLine(nameToNum[query]);
                }
            }
        }
    }
}
