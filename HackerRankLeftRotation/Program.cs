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

namespace HackerRankLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArray = rotLeft(new int[] {1, 2, 3, 4, 5}, 4);
            Console.WriteLine($"Hello World!{intArray}");
        }

        static int[] rotLeft(int[] a, int d)
        {
            if (a == null || a.Length == 0)
                return new int[]{};
            var tempArray = new List<int>();
            var length = a.Length;
            for (int i = 0; i < (length-d); i++)
            {
                tempArray.Add(a[i + d]);
            }

            for (int i = 0; i < d; i++)
            {
                tempArray.Add(a[i]);
            }

            return tempArray.ToArray();

        }
    }
}
