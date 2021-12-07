namespace ArrayLibrary;

public class Numbers
{
    public int Sum;

    public Numbers(ArrayPreparer preparer, int param)
    {
        Sum = sumOfMinNumbers(preparer, param);
    }

    public static int sumOfMinNumbers(ArrayPreparer preparer, int param)
    {
        return selectFunc(param)(preparer.Nums);
    }

    public delegate int Operation(int[] x);
    private static Operation selectFunc(int param)
    {
        Operation op;

        switch (param)
        {
            case 2:
                return op = (x) => x.OrderBy(n => n).Take(2).Sum();
            case 3:
                return op = (x) => x.OrderBy(n => n).Take(3).Sum();
            default:
                throw new ArrayException("Operation not found");
        }
    }






    // public int sumOf2MinNumbers(int take = 2)
    // {
    //     return Nums.OrderBy(n => n).Take(take).Sum();
    // }
}
