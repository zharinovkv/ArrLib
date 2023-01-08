using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayLibrary;

namespace NumbersTest;

[TestClass]
public class NumbersTest
{
    [DataRow(new int[] { 0, -10 }, "-10")]
    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, "-10")]
    [DataTestMethod]
    public void testSum2MinNums(int[] nums, string expected)
    {
        var numbers = new Numbers("sum2MinNums", nums).getValue();
        Assert.AreEqual(expected, numbers);
    }

    [DataRow(new int[] { }, "Array length less 2 is not allowed")]
    [DataRow(new int[] { 1 }, "Array length less 2 is not allowed")]
    [DataTestMethod]
    public void testSum2MinNums_WithEmptyArray(int[] nums, string expected)
    {
        try
        {
            new Numbers("sum2MinNums", nums).getValue();
        }
        catch (Exception ex)
        {
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, "7")]
    [DataTestMethod]
    public void testSumSliceNums(int[] nums, string expected)
    {
        var numbers = new Numbers("sumSliceNums", nums, 3).getValue();
        Assert.AreEqual(expected, numbers);
    }

    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, "72.71428571428571")]
    [DataTestMethod]
    public void testAverageNums(int[] nums, string expected)
    {
        var numbers = new Numbers("averageNums", nums).getValue();
        Assert.AreEqual(expected, numbers);
    }

    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, "4 0 3 19 492 -10 1")]
    [DataTestMethod]
    public void testToString(int[] nums, string expected)
    {
        var numbers = new Numbers("toString", nums).getValue();
        Assert.AreEqual(expected, numbers);
    }

    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, "3, 19, 1" )]
    [DataTestMethod]
    public void testOddNums(int[] nums, string expected)
    {
        var numbers = new Numbers("oddNums", nums).getValue();
        Assert.AreEqual(expected, numbers);
    }
}
