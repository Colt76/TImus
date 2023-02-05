using BenchmarkDotNet.Attributes;

namespace Sorting;

[MemoryDiagnoser]
public class BenchMark
{
    private int[] ArrayForSorting { get; set; } = new int[] { 0, 10, 5, 7, 1200, 6, 8, 9 };
    [Benchmark (Description = "Простой перебор два раза")]
    public void BubbleSimpleBench()
    {
        Bubble.BubbleSimple(ArrayForSorting);
    }

    [Benchmark (Description = "С оптимизацией по вторичном проходе, когда делаем проходов до точно вычесленных значений")]
    public void BubbleWithLimitBench()
    {
        Bubble.BubbleWithLimit(ArrayForSorting);
    }

    [Benchmark]
    public void BubbleWithEarlyStopBench()
    {
        Bubble.BubbleWithEarlyStop(ArrayForSorting);
    }
}