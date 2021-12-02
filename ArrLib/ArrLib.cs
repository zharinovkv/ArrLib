namespace ArrayLibrary;

public class Numbers
{
    public int[] Nums;
    
    public Numbers(ArrayPreparer arrayPreparer)
    {
        Nums = arrayPreparer.Nums;
    }

    public int sumTwoMinNumbers()
    {
        if (Nums.Length == 0)
        {
            return 0;
        }

        if (Nums.Length == 1)
        {
            return Nums[0];
        }

        return Nums.OrderBy(n => n).Take(2).Sum();
    }
}
