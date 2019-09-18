using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace AviraCodilityTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var abc =  solution2(new int[] { 1, 1, 2, -1, 2, -1 });
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks + "Solution: " + abc);
            stopwatch.Reset();
            stopwatch.Start();
            var abc2 =  solution(new int[] { 1, 1, 2, -1, 2, -1 });
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks + "Solution: " + abc2);
            Console.Read();
        }

        public static int solution(int[] A)
        {
            
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A == null || A.Length == 0)
                return 0;
            var trueMax = 0;
            //Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > trueMax && ifExist(A,-A[i]))
                    trueMax = A[i];
            }

            return trueMax;
        }

        static bool ifExist(int[] A, int i)
        {

            for (int x = 0; x < A.Length; x++)
            {
                if (A[x] == i)
                {
                    return true;
                }
            }
            return false;
        }

       


        static int solution2(int[] testArr)
        {
            bool matched = false;
            int a = 0;
            if (testArr == null || testArr.Length == 0)
                return 0;
            int b = testArr.Length - 1;

            Array.Sort(testArr);
            while (!matched)
            {
                if (testArr[a] == -testArr[b])
                {
                 
                    return Math.Abs(testArr[a]);
                }

                a++;
                if (a == b)
                {
                    a = 0;
                    b--;
                }
                if (a > b)
                {
                   // Console.WriteLine("Not Found");
                    break;
                }
            }
            return 0;
        }
    }
}
