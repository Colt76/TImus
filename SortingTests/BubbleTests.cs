﻿using Sorting;

namespace SortingTests;

public class BubbleTests
{
    private int[] ArrayForSorting { get; set; } = new int[] { 0, 10, 10, 5, 7, 7, 1200, 6, 8, 9 };
    private int[] ArraySorted { get; set; } = new int[] { 0, 5, 6, 7, 7, 8, 9, 10, 10, 1200 };

    [Fact]
    public void BubbleSimpleTest()
    {

        var sorted = Bubble.BubbleSimple(ArrayForSorting);

        Assert.Equal(ArraySorted, sorted);
    }
    [Fact]
    public void BubbleLimitTest()
    {

        var sorted = Bubble.BubbleWithLimit(ArrayForSorting);

        Assert.Equal(ArraySorted, sorted);
    }   
    [Fact]
    public void BubbleWithEarlyStopTest()
    {

        var sorted = Bubble.BubbleWithEarlyStop(ArrayForSorting);

        Assert.Equal(ArraySorted, sorted);
    }   
    [Fact]
    public void BubbleWithEarlyStopTest1()
    {

        var sorted = Bubble.BubbleWithEarlyStop1(ArrayForSorting);

        Assert.Equal(ArraySorted, sorted);
    }   
    [Fact]
    public void BubbleWithOtherDirectionTest()
    {

        var sorted = Bubble.BubbleWithOtherDirection(ArrayForSorting);

        Assert.Equal(ArraySorted, sorted);
    }   
}