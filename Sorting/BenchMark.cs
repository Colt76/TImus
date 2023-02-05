using BenchmarkDotNet.Attributes;

namespace Sorting;

[MemoryDiagnoser]
public class BenchMark
{
    [Benchmark]
    public void SimpleBubbleBench()
    {
        var sorting = new int[] { 0, 10, 5, 7, 1200, 6, 8, 9 };
        Bubble.BubbleSimple(sorting);
    }
}