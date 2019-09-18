using System;

namespace BinaryGap_Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(32));
            Console.Read();
        }

        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (N == 0)
                return 1;
            var count = 0;
            var maxCount = 0;
            var binStringArray = DecToBin(N).ToCharArray();
            for (int i = 0; i < binStringArray.Length; i++)
            {
               
                if (binStringArray[i] != '1')
                {
                    count++;
                }
                else
                {
                    if (maxCount < count)
                        maxCount = count;
                    count = 0;
                }
            }

            return maxCount;
        }

        public static string DecToBin(int N)
        {
            return Convert.ToString(N, 2); 
        }
    }
}
