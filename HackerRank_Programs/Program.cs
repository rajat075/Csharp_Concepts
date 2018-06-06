using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank_Programs.Extensions;
using HackerRank_Programs.Problems;

namespace HackerRank_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightedUniformStrings obj = new WeightedUniformStrings();

            Console.WriteLine('a'.GetASCII());

            Dictionary< char , int > charWeightTable = new Dictionary<char, int>();


            char EntryPointChar = 'a';
            int EntryPointWeight = 1;
            int startAscii = EntryPointChar.GetASCII();
            int exitAscii = startAscii + 26;


            for (int currentAscii = startAscii; currentAscii < exitAscii ; currentAscii++)
                charWeightTable.Add(Convert.ToChar(currentAscii), 
                           currentAscii - startAscii + EntryPointWeight);

            foreach (var charWeightTableRow in charWeightTable)
            {
                Console.WriteLine(charWeightTableRow.Key + " " + charWeightTableRow.Value);
            }
            Console.ReadLine();
        }
    }
}
