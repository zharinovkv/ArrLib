using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayLibrary;

namespace NumbersTest;

[TestClass]
public class NumbersTest
{
    [DataRow(new int[] { 0, -10 }, -10)]
    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, -10)]
    [DataTestMethod]
    public void testSum2MinNums(int[] nums, int expected)
    {
        var numbers = new Numbers("sum2MinNums", nums);
        Assert.AreEqual(expected, numbers.getInteger());
    }

    [TestMethod]
    public void testSum2MinNums_WithLongArray()
    {
        int[] nums = Enumerable.Range(0, 100000000).ToArray();
        var numbers = new Numbers("sum2MinNums", nums);
        Assert.AreEqual(1, numbers.getInteger());
    }

    [DataRow(new int[] { }, "Array length less 1 is not allowed")]
    [DataTestMethod]
    public void testSum2MinNums_WithEmptyArray(int[] nums, string expected)
    {
        try
        {
            new Numbers("sum2MinNums", nums);
        }
        catch (Exception ex)
        {
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [DataRow(new int[] { 2, -10 }, -8)]
    [DataTestMethod]
    public void testSumEvenNums(int[] nums, int expected)
    {
        var numbers = new Numbers("sumEvenNums", nums);
        Assert.AreEqual(expected, numbers.getInteger());
    }
}
