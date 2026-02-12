using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "fdsajkl;" || input == "jkl;fdsa")
            {
                Console.WriteLine("in-out");
            } 
            else if(input == "asdf;lkj" || input == ";lkjasdf")
            {
                Console.WriteLine("out-in");
            }
            else if(input == "asdfjkl;")
            {
                Console.WriteLine("stairs");
            }
            else if(input == ";lkjfdsa")
            {
                Console.WriteLine("reverse");
            }
            else
            {
                Console.WriteLine("molu");
            }
        }
    }
}
