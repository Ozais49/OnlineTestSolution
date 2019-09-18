using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 1, 6, 5,9,7};
            var count = solution(arr);
            Console.WriteLine(count);
            Console.Read();
        }

  

        public static int solution(int[] A)
        {
      
            var prev = 0;
            var sliceCount = 0;

            int[][] arrAys;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < prev)
                {
                    sliceCount++;
                }
              
                prev = A[i];
              
            }
         

            return sliceCount == 0? 1:sliceCount;
        }

        public static int[] SubArray(int[] data, int index, int length)
        {
            int[] result = new int[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
}
