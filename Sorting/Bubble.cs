namespace Sorting;

public class Bubble
{
    public static int[] BubbleSimple(int[] array)
    {
        for (var i = 0; i < array.Length-1; ++i)
        {
            for (var j = 0; j < array.Length - 1; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]); 
                }
            }
        }
        return array;
    }

    public static int[] BubbleWithLimit(int[] array)
    {
        for (var i = 0; i < array.Length-1; ++i)
        {
            for (var j = 0; j < array.Length - 1 - i; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]); 
                }
            }
        }
        return array;
    }

    public static int[] BubbleWithEarlyStop(int[] array)
    {
        var stop = true;
        for (var i = 0; i < array.Length-1; ++i)
        {
            for (var j = 0; j < array.Length - 1 - i; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    stop = false;
                }
            }

            if (stop)
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
            continueLoop = false;
            for (var j = 0; j < array.Length - 1 - i; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    continueLoop = true;
                }
            }

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
            continueLoop = false;
            for (var j = 0; j < array.Length - 1 - i; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    continueLoop = true;
                }
            }

            if (!continueLoop)
            {
                break;
            }

            if (i < array.Length)
            {
                continueLoop = false;
                for (var j = array.Length - 2 - i; j > 0; --j)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        continueLoop = true;
                    }
                }

                ++i;
            }
        }
        return array;
    }
}
