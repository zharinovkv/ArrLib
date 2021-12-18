namespace ArrayLibrary;

public class Numbers
{
    private DataContainer Result;

    private Dictionary<string, Func<int[], DataContainer>> Funcs = new Dictionary<string, Func<int[], DataContainer>>
    {
        {"sum2MinNums", nums => nums.Length >= 2 ? nums.OrderBy(n => n).Take(2).Sum().toContainer() :
            throw new Exception("Array length less 1 is not allowed")},
        {"sumEvenNums", nums => nums.Length >= 1 ? nums.Where(n => n % 2 == 0).Sum().toContainer() :
            throw new Exception("Array length less 1 is not allowed")},
        {"averageNums", nums => nums.Length >= 1 ? nums.Average().toContainer() :
            throw new Exception("Array length less 1 is not allowed")},
        {"toString", nums => nums.Length >= 1 ? string.Join(" ", nums).toContainer() :
            throw new Exception("Array length less 1 is not allowed")},
        {"oddNumsArray", nums => nums.Length >= 1 ? nums.Where(n => n % 2 != 0).ToArray().toContainer() :
            throw new Exception("Array length less 1 is not allowed")}
    };
    public Numbers(string func, int[] nums)
    {
        try
        {
            Result = Funcs[func](nums);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public int getValue()
    {
        return this.Result.intValue;
    }

}
