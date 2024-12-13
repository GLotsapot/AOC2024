using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AOC2024
{
    internal class D03P02(bool testRun = false) : IDxxPxx
    {
        public string DataFile { get; set; } = testRun ? "D03P02-Example.txt" : "D03P02-Puzzle.txt";
        public List<string> Log { get; set; } = [];

        public string GetAnswer()
        {
            var input = System.IO.File.ReadAllText("Data\\" + DataFile);
            var matches = Regex.Matches(input, "mul\\(([0-9]{1,3})\\,([0-9]{1,3})\\)");

            var total = 0;

            foreach (Match match in matches) {
                Log.Add(match.Value);
                var value1 = Int32.Parse(match.Groups[1].Value);
                var value2 = Int32.Parse(match.Groups[2].Value);

                total += value1 * value2;
            }
            Log.Add(String.Format("The total is: {0}", total));
            return total.ToString();
        }
    }
}
