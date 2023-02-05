using BenchmarkDotNet.Attributes;

namespace Sorting;

[MemoryDiagnoser]
public class BenchMark
{
    [Benchmark]
    public void BubbleSimpleBench()
    {
        Bubble.BubbleSimple(new int[] { 0, 10, 5, 7, 1200, 6, 8, 9 });
    }

    [Benchmark]
    public void BubbleWithLimitBench()
    {
        Bubble.BubbleWithLimit(new int[] { 0, 10, 5, 7, 1200, 6, 8, 9 });
    }
}