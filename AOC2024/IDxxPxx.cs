using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024
{
    internal interface IDxxPxx
    {
        List<String> Log { get; set; }
        string DataFile { get; set; }

        string GetAnswer();
    }
}
