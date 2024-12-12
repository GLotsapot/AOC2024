using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024
{
    internal class D02P01(bool testRun = false) : IDxxPxx
    {
        public string DataFile { get; set; } = testRun ? "D02P01-Example.txt" : "D02P01-Puzzle.txt";
        public List<string> Log { get; set; } = [];

        public string GetAnswer()
        {
            var totalSafeReports = 0;

            foreach(string report in System.IO.File.ReadAllLines("Data\\" + DataFile))
            {
                var levels = report.Split(" ");
                var levelSafe = true; // Assume to start that it's safe

                bool ascending = int.Parse(levels[0]) < int.Parse(levels[1]); // Determine if levels are going up or down
                for (int i = 0; i < levels.Length - 1; i++) 
                {

                    int value1 = Int32.Parse(levels[i]);
                    int value2 = Int32.Parse(levels[i+1]);
                    if (ascending)
                    {
                        levelSafe = levelSafe && (value1 < value2);
                    }
                    else
                    {
                        levelSafe = levelSafe && (value1 > value2);
                    }

                    var diff = Math.Abs(value1 - value2);
                    if (diff > 3 || diff < 1)
                    {
                        levelSafe = false;
                    }
                }
                Log.Add(String.Format("{1}\t{0}", report, levelSafe));
                
                if (levelSafe) { totalSafeReports++; }
            }

            Log.Add(String.Format("There were {0} safe reports", totalSafeReports));
            return totalSafeReports.ToString();
        }
    }
}
