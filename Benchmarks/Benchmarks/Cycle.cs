using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
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

        [Benchmark]
        public void GoToMethod()
        {
            int i = 0;

            Cycle:
                if (i < numInts.Length)
                {
                    numInts[i] = i;
                    i++;
                }
                else
                {
                    goto Finish;
                }
            goto Cycle;

            Finish:
                return;
        }
    }
}
