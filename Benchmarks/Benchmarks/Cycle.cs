using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;

namespace Benchmarks
{
    [NativeMemoryProfiler]
    [MinColumn, MaxColumn]
    [MemoryDiagnoser]
    public class Cycle
    {

        private int[] numInts = new int[1_000_000_000];

        [Benchmark]
        public void ForMethod()
        {
            for (int i = 0; i < numInts.Length; i++)
            {
                numInts[i] = i;
            }
        }

        [Benchmark]
        public void WhileMethod()
        {
            int i = 0;
            while (i < numInts.Length)
            {
                numInts[i] = i;
                i++;
            }
        }
    }
}
