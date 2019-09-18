using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerEarth
{
    class Program
    {

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int k = Convert.ToInt32(Console.ReadLine().Trim());

            int marksCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> marks = new List<int>();

            for (int i = 0; i < marksCount; i++)
            {
                int marksItem = Convert.ToInt32(Console.ReadLine().Trim());
                marks.Add(marksItem);
            }

            int result = numofPrizes(k, marks);
            Console.Write(result);
        }

        public static int numofPrizes(int k, List<int> marks)
        {
            if (marks != null && k > 0)
            {
                if (k < marks.Count)
                    return k;
                var newList = marks.OrderByDescending(p => p).ToList();

                var kthRank = newList.LastIndexOf(k);

                int count = 0;
                for (int i = 0; i < newList.Count; i++)
                {
                    if (newList[i] >= kthRank)
                        count++;

                }
                return count;
            }
            else return 0;

        }

        //static void Main(string[] args)
        //{
        //    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int keyTimesRows = Convert.ToInt32(Console.ReadLine().Trim());
        //    int keyTimesColumns = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<List<int>> keyTimes = new List<List<int>>();

        //    for (int i = 0; i < keyTimesRows; i++)
        //    {
        //        keyTimes.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(keyTimesTemp => Convert.ToInt32(keyTimesTemp)).ToList());
        //    }

        //    char result = slowestKey(keyTimes);

        //    //textWriter.WriteLine(result);

        //    //textWriter.Flush();
        //    //textWriter.Close();
        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //    Console.WriteLine("Hello World!");
        //}

        //public static char slowestKey(List<List<int>> keyTimes)
        //{

        //    int slowestAscii = 0;
        //    int previousIndex = 0;
        //    int timeDiff = 0;
        //    List<int> previousItem = new List<int>();
        //    List<int> timeDiffArray = new List<int>();

        //    var charDict = new Dictionary<int, char>
        //          {
        //            { 0,'a' },
        //                { 1, 'b' },{ 2, 'c'},{ 3, 'd'},{ 4, 'e'},{ 5, 'f'},{6, 'g'},{7, 'h'},{8, 'i'},{9, 'j'},{10, 'k'},{ 11, 'l'},{ 12, 'm'},{ 13, 'n'},{ 14, 'o'},{ 15, 'p'},{ 16, 'q'},{ 17, 'r'},{ 18, 's'},{ 19, 't'},{ 20, 'u'},{ 21, 'v'},{ 22, 'w'},{ 23, 'x'},{ 24, 'y'},{ 25, 'z'}
        //        };

        //    for (int i = 0; i < keyTimes.Count; i++)
        //    {
        //        if (i == 0)
        //        {
        //            previousIndex = 0;
        //            previousItem = new List<int>()
        //            { 0,0}; 
        //        }
        //        else
        //        {
        //            previousIndex = i - 1;
        //            previousItem = keyTimes[previousIndex];
        //        }

        //        var currentItem = keyTimes[i];
        //        //Console.WriteLine(currentItem);
        //        //Console.WriteLine(currentItem[1]);
        //        timeDiff = currentItem[1] - previousItem[1];
        //        //Console.WriteLine("timeDiff " + timeDiff);
        //        timeDiffArray.Add(timeDiff);

        //        var slowestTime = timeDiffArray.Max();

        //        slowestAscii = timeDiffArray.IndexOf(slowestTime); 


        //    }
        //    return charDict[slowestAscii];


        //}

        static int Workbook(int n, int k, int[] arr)
        {
            var currPageNumber = 0;
            var specialProblems = 0;
            for (int i = 0; i < n; i++)
            {
                var currChapterQuesCount = arr[i];
                var questionStart = 1 - k;
                var questionEnd = 0;
                do
                {
                    currPageNumber++;
                    questionStart += k;
                    if (currChapterQuesCount >= k)
                        questionEnd += k;
                    else
                        questionEnd += currChapterQuesCount;

                    if (currPageNumber >= questionStart && currPageNumber <= questionEnd)
                        specialProblems++;

                    currChapterQuesCount -= k;
                } while (currChapterQuesCount > 0);
            }
            return specialProblems;
        }

    }
}
