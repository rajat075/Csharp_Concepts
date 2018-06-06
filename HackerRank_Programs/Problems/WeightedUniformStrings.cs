using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Programs.Problems
{
    class WeightedUniformStrings
    {
        void RunCode()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            int[] queries = new int[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            //string[] result = WeightedUniformStrings(s, queries);

            //textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }

        private static string[] weightedUniformStrings(string s, int[] queries)
        {
            string[] result = new string[10];
            return result;
        }

    }
}
