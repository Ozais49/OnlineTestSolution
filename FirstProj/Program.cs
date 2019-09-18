using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //
        //    var readInput = Console.ReadLine();
        //    var param = solution(readInput);

        //    Console.WriteLine(param);
        }
        // Count Unique
        public static int countNonUnique(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                return 0;
            var count = numbers.GroupBy(o => o).Count(o => o.ToList().Count != 1 );
            return count;
        }
        //sum
        public static int arraySum(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                return 0;
            var sum = numbers.ToArray().Sum();
            return sum;

        }

        public static string lastLetters(string word)
        {
            if (string.IsNullOrEmpty(word))
                return string.Empty;
            var stringArray = word.ToCharArray();
            var len = stringArray.Length;
            if (len < 2)
                return word;
            string result = word[len - 1] + " " + word[len - 2];
 
            return result;
        }

        static string solution(string param)
        {
            if (string.IsNullOrEmpty(param))
                return string.Empty;
            var stringArray = param.ToCharArray();
            for (int i = 1; i <= stringArray.Length; i++)
            {
                if (i % 3 == 0)
                    stringArray[i-1] = char.ToUpper(stringArray[i-1]);
                if (i % 5 == 5)
                    stringArray[i-1] = ' ';
            }
            var result =  new string(stringArray);
            return result;
        }
    }
}
