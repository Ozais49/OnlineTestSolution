using System;
using System.Linq;
using System.Collections.Generic;
namespace Molybdenum_Codility_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {};
            int K = 0;
            int M = 2;
            var result = solution(K, M, null);
            Console.WriteLine(result.ToString());

        }

        public static int[] solution(int K, int M, int[] A)
        {
            if(A==null || A.Length ==0)
                return new int[] { };
            int N = A.Length;
            var subArr = new List<int>();
            var tempArr = new int[N];
            Array.Copy(A, tempArr, N);
         
         
            for (int i = 0; i < N; i++)
            {
                if (K + i > N)
                    break;
                Array.Copy(A, tempArr, N);
                for (int j = i; j < K+i; j++)
                {
                    tempArr[j]= tempArr[j]+1;
                }

                var tempMaxCount = MaxOccurrence(tempArr);

                if (tempMaxCount.Item2 > (N/2))
                {
                  
                    subArr.Add(tempMaxCount.Item1);
                }
                
            }
            if (subArr.Count == 0)
                return new int[] { };
            return subArr.Distinct().OrderBy(p=>p).ToArray();
        }

        static Tuple<int,int> MaxOccurrence(int[] numbers)
        {
            var groups = numbers.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
          //  Console.WriteLine("The most common number is {0} and it appears {1} times", largest.Key, largest.Count());
            return new Tuple<int, int>(largest.Key, largest.Count());
        }
    }
}
