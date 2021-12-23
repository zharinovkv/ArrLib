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
        Assert.AreEqual(expected, numbers.getItemInteger());
    }

    [TestMethod]
    public void testSum2MinNums_WithLongArray()
    {
        int[] nums = Enumerable.Range(0, 100000000).ToArray();
        var numbers = new Numbers("sum2MinNums", nums);
        Assert.AreEqual(1, numbers.getItemInteger());
    }

    [DataRow(new int[] { }, "Array length less 2 is not allowed")]
    [DataRow(new int[] { 1 }, "Array length less 2 is not allowed")]
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

    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, 7)]
    [DataTestMethod]
    public void testSumSliceNums(int[] nums, int expected)
    {
        var numbers = new Numbers("sumSliceNums", nums, 3);
        Assert.AreEqual(expected, numbers.getItemInteger());
    }

    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, 72.71428571428571)]
    [DataTestMethod]
    public void testAverageNums(int[] nums, double expected)
    {
        var numbers = new Numbers("averageNums", nums);
        Assert.AreEqual(expected, numbers.getItemDouble());
    }

    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, "4 0 3 19 492 -10 1")]
    [DataTestMethod]
    public void testToString(int[] nums, string expected)
    {
        var numbers = new Numbers("toString", nums);
        Assert.AreEqual(expected, numbers.getItemString());
    }

    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, new int[] { 3, 19, 1 })]
    [DataTestMethod]
    public void testOddNumsArray(int[] nums, int[] expected)
    {
        var numbers = new Numbers("oddNumsArray", nums);
        CollectionAssert.AreEqual(expected, numbers.getItemArray());
    }
}
