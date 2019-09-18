using System;
using System.IO;


namespace FlatlandSpaceStations
{
    class Program
    {
        // Complete the flatlandSpaceStations function below.
        static int flatlandSpaceStations(int n, int[] c)
        {

            if (c == null || c.Length == 0)
                return 0;
            var m = c.Length;

            if (n == m)
                return 0;
            else
            {
                int maxDist = 0;
                for (int j = 0; j < n; j++)
                {
                    var nearestDist = 0;
                    for (int i = 0; i < m; i++)
                    {
                        
                        var tempDist = Math.Abs(j - c[i]);
                        if (i == 0)
                            nearestDist = tempDist;
                        if (tempDist < nearestDist)
                            nearestDist = tempDist;
                    }
                    //var tempMax = Math.Abs(j - c[i]);
                    if (nearestDist > maxDist)
                        maxDist = nearestDist;

                }
                return maxDist;
            }
              
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = { "5","2"};

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(new string[] { "0","4"}, cTemp => Convert.ToInt32(cTemp))
            ;
            int result = flatlandSpaceStations(n, c);

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
