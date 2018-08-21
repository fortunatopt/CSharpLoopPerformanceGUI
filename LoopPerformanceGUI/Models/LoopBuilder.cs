using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPerformanceGUI
{
    public static class LoopBuilder
    {
        public static List<int> PopulateLoop(this long rows)
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < rows; i++)
                ints.Add(i);
            return ints;
        }
        public static int[] PopulateArray(this long rows)
        {
            List<int> ints = new List<int>();
            for (int i = 0; i < rows; i++)
                ints.Add(i);
            return ints.ToArray();
        }
    }
}
