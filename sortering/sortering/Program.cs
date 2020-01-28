using System;
using System.Diagnostics;

namespace sortering
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            int[] infogande = RandomNumbers();
            sw.Start();
            Insertion(infogande);
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
            int[] numbers = new int[100000];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(numbers.Length);
            return numbers;
        }
        public static void Insertion (int [] lista)
        {
            int a, m;
            int length = lista.Length; if (length < 2) return;
            int temp;

            for (m=1; m<length; m++)
            {
                temp = lista[m];
                a = m - 1;

               while (a >= 0 && lista [a] > temp)

                {
                    lista[a + 1] = lista[a];
                    a--;
                }
                lista[a + 1] = temp;
            }
        }
    }
}
