namespace Sorting;

public class Bubble
{
    private static bool SingleBubble(ref int[] array, int from, int to, int increment = 1)
    {
        var ret = false;
        for (var i = from ; i != to; i += increment)
        {
            if (array[i] > array[i + 1])
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
                ret = true;
            }
        }

        return ret;
    }

    public static int[] BubbleSimple(int[] array)
    {
        for (var i = 0; i < array.Length-1; ++i)
        {
            SingleBubble(ref array, 0, array.Length - 1);
        }
        return array;
    }

    public static int[] BubbleWithLimit(int[] array)
    {
        for (var i = 0; i < array.Length-1; ++i)
        {
            SingleBubble(ref array, 0, array.Length - 1 - i);
        }
        return array;
    }

    public static int[] BubbleWithEarlyStop(int[] array)
    {
        var stop = true;
        for (var i = 0; i < array.Length-1; ++i)
        {
            if (!SingleBubble(ref array, 0, array.Length - 1 - i))
            {
                break;
            }
        }
        return array;
    }

    public static int[] BubbleWithEarlyStop1(int[] array)
    {
        var continueLoop = true;
        var i = 0;
        while (i < array.Length && continueLoop)
        {
            continueLoop = SingleBubble(ref array, 0, array.Length - 1 - i);
            ++i;
        }
        return array;
    }
    
    public static int[] BubbleWithOtherDirection(int[] array)
    {
        var continueLoop = true;
        var i = 0;
        while (i < array.Length && continueLoop)
        {
            continueLoop = SingleBubble(ref array, 0, array.Length - 1 - i);

            if (continueLoop && i < array.Length)
            {
                continueLoop = SingleBubble(ref array, array.Length - 2 - i, 1, -1);
                ++i;
            }
        }
        return array;
    }
}
