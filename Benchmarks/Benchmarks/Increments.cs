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
    public class Increments
    {
        private int x = 0;

        [Benchmark]
        public int BasicIncrement()
        {
            for (var i = 0; i < 1_000_000_000; i++)
                x = x + 1;

            return x;
        }

        [Benchmark]
        public int Precrement()
        {
            for (var i = 0; i < 1_000_000_000; i++)
                ++x;

            return x;
        }

        [Benchmark]
        public int Postcrement()
        {
            for (var i = 0; i < 1_000_000_000; i++)
                x++;

            return x;
        }

        [Benchmark]
        public int IncrementViaPlusEquels()
        {
            for (var i = 0; i < 1_000_000_000; i++)
                x+=1;

            return x;
        }
    }
}
