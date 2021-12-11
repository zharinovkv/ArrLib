using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayLibrary;

namespace NumbersTest;

[TestClass]
public class NumbersTest
{
    [DataRow(new int[] { 0, -10 }, -10)]
    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, -10)]
    [DataTestMethod]
    public void sumOfTwoMinNumbersTest(int[] nums, int assert)
    {
        var result = new Numbers("min2sum", nums).Result;
        Assert.AreEqual(result, assert);
    }

    [DataRow(new int[] { 0, -10 , 4}, -2.0)]
    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, 171.6666666666666667)]
    [DataTestMethod]
    public void averageOfThreeMaxNumbersTest(int[] nums, double assert)
    {
        var result = new Numbers("max3average", nums).Result;
        Assert.AreEqual(result, assert);
    }

    [DataRow(new int[] { 0, -10 }, -10)]
    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, 486)]
    [DataTestMethod]
    public void sumOfEvenNumbersTest(int[] nums, int assert)
    {
        var result = new Numbers("evenSum", nums).Result;
        Assert.AreEqual(result, assert);
    }

    [TestMethod]
    public void BigArrayTest()
    {
        int[] nums = BigArray();
        var result = new Numbers("min2sum", nums).Result;
        Assert.AreEqual(result, 1);
    }

    [DataRow(new int[] { }, "Array length less 2 is not allowed")]
    [DataRow(new int[] { 0 }, "Array length less 2 is not allowed")]
    [DataTestMethod]
    public void ExceptionTest(int[] nums, string assert)
    {
        try
        {
            new Numbers("min2sum", nums);
        }
        catch (Exception ae)
        {
            Assert.AreEqual(ae.Message, assert);
        }
    }

    [DataRow(new int[] { 0, 1 }, "Array length less 3 is not allowed")]
    [DataTestMethod]
    public void max3averageExceptionTest(int[] nums, string assert)
    {
        try
        {
            new Numbers("max3average", nums);
        }
        catch (Exception ae)
        {
            Assert.AreEqual(ae.Message, assert);
        }
    }

    public int[] BigArray(int length = 100000000)
    {
        int[] nums = new int[length];
        for (int i = 0; i < length; i++)
        {
            nums[i] = i;
        }
        return nums;
    }
}
