using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCodility
{
 
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] A = { 10, 11, 1, 9, 8, 10, 7, 4 };
            int K = 3;
            int L = 2;
            var max = solution(A, K, L);
          
            Console.WriteLine(max);
            Console.Read();
        }

        public static int solution(int[] A, int K, int L)
        {
            if(A.Length < K+L)
                return -1;
            var max = FindMax(A, K, L);
            var reverseMax = FindMax(A, L, K);
            if (reverseMax > max)
                max = reverseMax;
            return max;
        }
        public static int FindMax(int[] A, int K, int L)
        {
            var N = A.Length;
            var max = 0;
           

            try
            {
                for (int i = 0; i < (N - (K + L)); i++)
                {
                    var maxA = SubArray(A, i, K).Sum();
                    var maxB = 0;
                    for (int j = K + i; j < (N - L); j++)
                    {
                        var tempB = 0;
                        tempB = SubArray(A, j, K).Sum();
                        if (tempB > maxB)
                        {
                            maxB = tempB;
                        }
                    }
                    if (maxA + maxB > max)
                        max = maxA + maxB;

                }




            }
            catch (Exception)
            {

                return -1;
            }

            return max;
        }
        public static int[] SubArray(int[] data, int index, int length)
        {
            int[] result = new int[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
}
