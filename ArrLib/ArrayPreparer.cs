namespace ArrayLibrary;

public class ArrayPreparer
{
    public int[] Nums;

    public ArrayPreparer(int[] nums)
    {
        if (nums.Length < 2)
        {
            throw new ArrayException("Array length less 2 is not allowed");
        }
        Nums = nums;
    }
}
