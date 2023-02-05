using BenchmarkDotNet.Attributes;

namespace Sorting;

[MemoryDiagnoser]
public class BenchMark
{
    private int[] ArrayForSorting { get; set; } = new int[] { 0, 10, 5, 7, 1200, 6, 8, 9 };
    [Benchmark]
    public void BubbleSimpleBench()
    {
        Bubble.BubbleSimple(ArrayForSorting);
    }
    [Benchmark]
    public void BubbleWithLimitBench()
    {
        Bubble.BubbleWithLimit(ArrayForSorting);
    }
}