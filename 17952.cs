using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    class Work
    {
        public enum isWork
        {
            notwork,
            work
        }
        public isWork state;
        public int workScore = 0;
        public int workMinute = 0;


    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 과제는 가장 최근에 나온 순서대로 한다. 또한 과제를 받으면 바로 시작한다.
             * 과제를 하던 도중 새로운 과제가 나온다면, 하던 과제를 중단하고 새로운 과제를 진행한다.
             * 새로운 과제가 끝났다면, 이전에 하던 과제를 이전에 하던 부분부터 이어서 한다.
             */

            Work w = new Work();
            List<Work> workList = new List<Work>();

            int minute = int.Parse(Console.ReadLine());

            for (int i = 0; i < minute; i++)
            {
                string[] work = Console.ReadLine().Split(' ');

                if(int.Parse(work[0]) == 0)
                {
                    w.state = Work.isWork.notwork;
                    w.workScore = 0;
                    w.workMinute = 0;
                }
                else
                {
                    w.state = Work.isWork.work;
                    w.workScore = int.Parse(work[1]);
                    w.workMinute = int.Parse(work[2]);
                }
                
                Console.WriteLine($"{w.state} {w.workScore} {w.workMinute}");
            }
        }
    }
}
