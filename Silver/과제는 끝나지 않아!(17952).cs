using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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

        public Work(int score, int minute)
        {
            state = isWork.work;
            workScore = score;
            workMinute = minute;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<Work> workStack = new Stack<Work>();

            int totalScore = 0;
            int minute = int.Parse(Console.ReadLine());

            for (int i = 0; i < minute; i++)
            {
                string[] work = Console.ReadLine().Split(' ');

                if (int.Parse(work[0]) == 1)
                {
                    Work newWork = new Work(int.Parse(work[1]), int.Parse(work[2]));

                    workStack.Push(newWork);

                    if(workStack.Count > 0)
                    {
                        Work currentWork = workStack.Peek();

                        currentWork.workMinute--;

                        if(currentWork.workMinute == 0)
                        {
                            totalScore += currentWork.workScore;
                            workStack.Pop();
                        }
                    }
                }
                else
                {
                    if (workStack.Count > 0)
                    {
                        Work currentWork = workStack.Peek();

                        currentWork.workMinute--;

                        if (currentWork.workMinute == 0)
                        {
                            totalScore += currentWork.workScore;
                            workStack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine(totalScore);
        }
    }
}
