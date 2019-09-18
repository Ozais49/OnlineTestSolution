using System;
using System.Linq;
namespace FairRations
{
    class Program
    {
        static int count = 0;
        static int fairRations(int[] B)
        {
            var N = B.Length;
            if (N == 0)
                return 0;
            if (B.All(p => p % 2 == 0))
                return count;

            for (int i = N - 1; i > 0; i--)
            {
                if (isOdd(B[i]))
                {
                    B[i - 1]++;
                    count += 2;
                }
            }

            if (isOdd(B[0]))
            {
                return -1;
            }
            else return count;




          
        }

       
        static bool isOdd(int i)
        {
            return i % 2 == 1;
        }
        static void Main(string[] args)
        {
           

            //int N = Convert.ToInt32(Console.ReadLine());

            int[] B = new int[] { 3,4,5,4,6}; // Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp));


            int result = fairRations(B);

            Console.WriteLine(result);

            
        }
    }
}
