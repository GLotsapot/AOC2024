using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024
{
    internal class D03P01(bool testRun = false) : IDxxPxx
    {
        public string DataFile { get; set; } = testRun ? "D03P01-Example.txt" : "D03P01-Puzzle.txt";
        public List<string> Log { get; set; } = [];

        public string GetAnswer()
        {
            throw new NotImplementedException();
        }
    }
}
