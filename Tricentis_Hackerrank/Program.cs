using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tricentis_HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][]
            {
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 1, 0, 0, 0, 0},
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 0, 2, 4, 4, 0},
                new int[] {0, 0, 0, 2, 0, 0},
                new int[] {0, 0, 1, 2, 4, 0 }
            };

           

            int result = hourglassSum(arr);

            Console.WriteLine("Hello World!");
        }



        //HourGlassSum
        static int hourglassSum(int[][] arr)
        {
            if (arr.Length == 0)
                return 0;
            var rowLength = arr.Length;
            //var colLength = arr.GetLength(1);
            if (rowLength < 3 || arr[0].Length < 3)
                return 0;
            int? sumMax = null;
            for (int x = 0; x <= 3; x++)
            {
                for (int y = 0; y <= 3; y++)
                {
                    var tempSum = arr[x][y] + arr[x][y + 1] + arr[x][y + 2]
                                  + arr[x + 1][y + 1]
                                  + arr[x + 2][y] + arr[x + 2][y + 1] + arr[x + 2][y + 2];
                    if (tempSum > sumMax || sumMax == null)
                        sumMax = tempSum;
                }
            }

            int sum = sumMax ?? default(int);
            return sum;
        }

        //OddNumbers
        static List<int> oddNumbers(int l, int r)
        {
            List<int> oddInts = new List<int>();
            for (int i = l; i <= r; i++)
            {
                if(i%2 == 0)
                    oddInts.Add(i);
            }

            return oddInts;
        }

        static bool ifExist(List<int> arr, int i)
        {

            if (arr == null)
                return false;
            var length = arr.Count;
            if (length == 0)
                return false;
            for (int x = 0; x < arr.Count; x++)
            {
                if (arr[x] == i)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
