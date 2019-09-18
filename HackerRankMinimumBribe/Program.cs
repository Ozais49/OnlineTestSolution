using System;

namespace HackerRankMinimumBribe
{
    class Program
    {
        static void Main(string[] args)
        {
            minimumBribes(new[] {2, 1, 5, 3, 4});
            Console.WriteLine("Hello World!");
        }

        static void minimumBribes(int[] q)
        {
            if (q == null || q.Length == 0)
            {
                Console.Write(0);
            }
            else { 
                int bribe = 0;
                for (int i = 0; i < q.Length; i--)
                {
                    var pos = Array.IndexOf(q, i) + 1;
                    if (pos - i > 2)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                    else if (pos - i > 1)
                    {
                        bribe+=2;
                    }
                    else if (i - pos > 0)
                    {
                        bribe += 1;
                    }
                   
                }
                Console.WriteLine(bribe);
            }

        }

    }
}
