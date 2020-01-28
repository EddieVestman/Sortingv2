using System;
using System.Diagnostics;

namespace sortering
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            int[] bubble = RandomNumbers();
            sw.Start();
            BubbelSorter(bubble);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds);
        }
        public static void BubbelSorter(int[] list)
        {
            for (int L=list.Length-1; L>0; L--)
            {
                for (int n=0; n<L; n++)
                {
                    if (list[n] > list[n+1])
                      {
                        int temp = list[n];
                        list[n] = list[n + 1];
                        list[n + 1] = temp;

                      }
                }
            }
           /*for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }*/
        }
        public static int[] RandomNumbers()
        {
            Random random = new Random();
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(numbers.Length);
            return numbers;
        }
    }
}
