using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayLibrary;

namespace NumbersTest;

[TestClass]
public class NumbersTest
{
    [DataRow(new int[] { }, 0)]
    [DataRow(new int[] { 0 }, 0)]
    [DataRow(new int[] { -10 }, -10)]
    [DataRow(new int[] { 0, -10 }, -10)]
    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, -10)]
    [DataTestMethod]
    public void sumTwoMinNumbersTest(int[] nums, int result)
    {
        var numbers = new Numbers(new ArrayPreparer(nums));
        var actual = numbers.sumTwoMinNumbers();
        Assert.AreEqual(result, actual);
    }

    [TestMethod]
    public void BigArrayTest()
    {
        int[] nums = NumbersTest.arr(); //new int[100000000];
        // for (int i = 0; i < 100000000; i++)
        // {
        //     nums[i] = i;
        // }
        var numbers = new Numbers(new ArrayPreparer(nums));
        Assert.AreEqual(1, numbers.sumTwoMinNumbers());
    }

    public int[] FullName => new int[100000000];

    [TestMethod]
    public void NullArrayTest()
    {
        int[] nums = new int[100000000];
        var numbers = new Numbers(new ArrayPreparer(FullName));
        Assert.AreEqual(0, numbers.sumTwoMinNumbers());
    }

    private static int[] arr(int lenth = 100000000)
    {
        int[] nums = new int[lenth];
        for (int i = 0; i < lenth; i++)
        {
            nums[i] = i;
        }
        return nums;
    }
}


