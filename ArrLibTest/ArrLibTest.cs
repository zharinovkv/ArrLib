using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayLibrary;
using System.Linq;

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
        Assert.AreEqual(expected, numbers.getValue());
    }

    [TestMethod]
    public void testSum2MinNums_WithLongArray()
    {
        int[] nums = Enumerable.Range(0, 100000000).ToArray();
        var numbers = new Numbers("sum2MinNums", nums);
        Assert.AreEqual(1, numbers.getValue());
    }

    [TestMethod]
    public void testSum2MinNums_WithLongEmptyArray()
    {
        int[] nums = new int[100000000];
        var numbers = new Numbers("sum2MinNums", nums);
        Assert.AreEqual(0, numbers.getValue());
    }

    [DataRow(new int[] { 2, -10 }, -8)]
    [DataTestMethod]
    public void testSumEvenNums(int[] nums, int expected)
    {
        var numbers = new Numbers("sumEvenNums", nums);
        Assert.AreEqual(expected, numbers.getValue());
    }
}
