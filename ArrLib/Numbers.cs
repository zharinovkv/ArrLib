namespace ArrayLibrary;

public class Numbers
{
    public int[] Nums;

    public Numbers(ArrayPreparer preparer)
    {
        try
        {
            Nums = preparer.Nums;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Возникло исключение {ex.Message}");
        }
    }

    public int sumOfTwoMinNumbers()
    {
        return Nums.OrderBy(n => n).Take(2).Sum();
    }
}
