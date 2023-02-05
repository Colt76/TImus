namespace Sorting;

public static partial class Program
{
    private static void Main()
    {
        var sorting = new int[] { 0, 10, 5, 7, 1200, 6, 8, 9 };
        var sorted = Bubble.BubbleSimple(sorting);
        Testing(sorted);
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