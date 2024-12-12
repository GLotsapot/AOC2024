using System.Collections.Generic;
using System.Diagnostics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace AOC2024
{
    public class D01P01(bool testRun = false) : IDxxPxx
    {
        public string DataFile { get; set; } = testRun ? "D01P01-Example.txt" : "D01P01-Puzzle.txt";
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
            listA.Sort(); listB.Sort();

            var totalDistance = 0;
            for (int i = 0; i < listA.Count; i++)
            {
                var distance = Math.Abs(listA[i] - listB[i]);
                totalDistance += distance;
                Log.Add(String.Format("Distance between {0} and {1} is: {2}", listA[i], listB[i], distance));
            }
            Log.Add(String.Format("The total distance is: {0}", totalDistance));
            
            return totalDistance.ToString();
        }
    }
}


