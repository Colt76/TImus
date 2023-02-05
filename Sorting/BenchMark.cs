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

    [Benchmark (Description = "Выход если сортировка уже произошла, с выходом из цикла по break")]
    public void BubbleWithEarlyStopBench()
    {
        Bubble.BubbleWithEarlyStop(ArrayForSorting);
    }

    [Benchmark (Description = "Выход если сортировка уже произошла, c циклом while true, чуть лучше кажись")]
    public void BubbleWithEarlyStopBench1()
    {
        Bubble.BubbleWithEarlyStop1(ArrayForSorting);
    }

    [Benchmark (Description = "Двунаправленная сортировка")]
    public void BubbleWithOtherDirectionBench()
    {
        Bubble.BubbleWithOtherDirection(ArrayForSorting);
    }
}