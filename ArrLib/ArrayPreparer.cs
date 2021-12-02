namespace ArrayLibrary;

public class ArrayPreparer
{
    public int[] Nums;

    public ArrayPreparer(int[] nums)
    {
        if (nums?.Length != 0)
        {
            Nums = nums.Where(x => x != null).ToArray();
        }
        else
        {
            Nums = nums;
        }
    }
}