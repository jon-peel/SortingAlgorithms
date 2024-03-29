﻿using Xunit;

namespace SortingAlgorithms;

public partial class SortingTests
{
    readonly int[] _array,  _ordered;

    public SortingTests()
    {
        _array = Common.RandomArray(1000);
        _ordered = _array.OrderBy(x => x).ToArray();
    }

    [Fact]
    public void BubbleSortTest()
    {
        BubbleSort.Sort(_array);
        Assert.Equal(_ordered, _array);
    }

    [Fact]
    public void SelectionSortTest()
    {
        SelectionSort.Sort(_array);
        Assert.Equal(_ordered, _array);
    }

    [Fact]
    public void InsertionSortTest()
    {
        InsertionSort.Sort(_array);
        Assert.Equal(_ordered, _array);
    }

    [Fact]
    public void ShellSortTest()
    {
        ShellSort.Sort(_array);
        Assert.Equal(_ordered, _array);
    }

    [Fact]
    public void MergeSortTest()
    {
        MergeSort.Sort(_array);
        Assert.Equal(_ordered, _array);
    }
}