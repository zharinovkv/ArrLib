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
    public void sumOfTwoMinNumbersTest(int[] nums, int result)
    {
        var numbers = new Numbers(new ArrayPreparer(nums));
        var actual = numbers.sumOfTwoMinNumbers();
        Assert.AreEqual(result, actual);
    }

    [TestMethod]
    public void BigArrayTest()
    {
        int[] nums = BigArray();
        var numbers = new Numbers(new ArrayPreparer(nums));
        Assert.AreEqual(1, numbers.sumOfTwoMinNumbers());
    }

    [DataRow(new int[] { }, "Array length less 2 is not allowed")]
    [DataRow(new int[] { 0 }, "Array length less 2 is not allowed")]
    [DataTestMethod]
    public void ExceptionTest(int[] nums, string result)
    {
        try
        {
            new Numbers(new ArrayPreparer(nums)).sumOfTwoMinNumbers();
        }
        catch (ArrayException ae)
        {
            Assert.AreEqual(result, ae.Message);
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


