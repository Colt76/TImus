using BenchmarkDotNet.Running;

namespace Sorting;

public static class Program
{
    private static void Main()
    {
        var summary = BenchmarkRunner.Run<BenchMark>();
    }

    private static void Testing(int[] sorted)
    {
        for (var i = 0; i < sorted.Length; ++i)
        {
            Console.WriteLine(sorted[i]);
            if (i < sorted.Length - 1 && sorted[i] > sorted[i + 1])
            {
                Console.WriteLine("Ошибка!!");
            }
        }
    }
}