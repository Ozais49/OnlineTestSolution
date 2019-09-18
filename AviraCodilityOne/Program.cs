using System;
using System.Collections.Generic;
using System.Linq;
namespace AviraCodilityOne
{
    class Program
    {
        //minimum negative in array
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            solution(new int[] { -6, -91, 1011, -100, 84, -22, 0, 1, 473 });
            Console.Read();
        }
        public static int solution(int[] A)
        {
            if (A == null || A.Length == 0)
                return 0;
            var B = OddArray(A);
            if (A == null || A.Length == 0)
                return 0;
            var minValue = Min(B);
            return minValue;
        }

        public static int[] OddArray(int[] A)
        {
            var subArr = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (isOdd(A[i]))
                {
                    subArr.Add(A[i]);
                }
            }
            return subArr.ToArray();


        }

        static bool isOdd(int i)
        {
            return i % 2 == 1 || i%2 ==-1;
        }

        public static int Min(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];

                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }
    }
}
