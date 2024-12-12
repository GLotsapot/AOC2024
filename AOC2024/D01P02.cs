using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024
{
    public class D01P02(bool testRun = false) : IDxxPxx
    {
        public string DataFile { get; set; } = testRun ? "D01P02-Example.txt" : "D01P02-Puzzle.txt";
        public List<string> Log { get; set; } = [];

        public string GetAnswer()
        {
            var listA = new List<int>();
            var listB = new List<int>();

            var input = System.IO.File.ReadAllLines("Data\\" + DataFile);
            foreach (var line in input)
            {
                var results = line.Split("   ");
                listA.Add(int.Parse(results[0]));
                listB.Add(int.Parse(results[1]));
            }

            var totalScore = 0;
            for (int i = 0; i < listA.Count; i++)
            {
                var thisScore = listB.Count(n => n == listA[i]);
                Log.Add(String.Format("I looked for {0} and found {1} many", listA[i], thisScore));
                totalScore += listA[i] * thisScore;
            }
            Log.Add(String.Format("The total score is: {0}", totalScore));
            return totalScore.ToString();
        }
    }
}