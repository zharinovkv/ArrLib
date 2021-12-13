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
    public void testSum2MinNums(int[] nums, int expected)
    {
        var numbers = new Numbers("sum2MinNums", nums);
        Assert.AreEqual(expected, numbers.Result);
    }

    [TestMethod]
    public void testSum2MinNumsWithLongArray()
    {
        int[] nums = array();
        var numbers = new Numbers("sum2MinNums", nums);
        Assert.AreEqual(1, numbers.Result);

        int[] array(int length = 100000000)
        {
            int[] nums = new int[length];
            for (int i = 0; i < length; i++)
            {
                nums[i] = i;
            }
            return nums;
        }
    }

    [DataRow(new int[] { 0, -10 }, -10)]
    [DataRow(new int[] { 4, 0, 3, 19, 492, -10, 1 }, 486)]
    [DataTestMethod]
    public void testSumEvenNums(int[] nums, int expected)
    {
        var numbers = new Numbers("sumEvenNums", nums);
        Assert.AreEqual(expected, numbers.Result);
    }
}
