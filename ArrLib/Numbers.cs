namespace ArrayLibrary;

public class Numbers
{
    private Tuple<Int32?, Double?, String?, Array?>? Result;

    private Dictionary<string, Func<int[], Tuple<Int32?, Double?, String?, Array?>>> Functions =
        new Dictionary<string, Func<int[], Tuple<Int32?, Double?, String?, Array?>>>
    {
        {"sum2MinNums", nums => nums.Length >= 2 ? nums.OrderBy(n => n).Take(2).Sum().toContainer() :
            throw new Exception("Array length less 1 is not allowed")},
        {"sumEvenNums", nums => nums.Length >= 1 ? nums.Where(n => n % 2 == 0).Sum().toContainer() :
            throw new Exception("Array length less 1 is not allowed")},
        {"averageNums", nums => nums.Length >= 1 ? nums.Average().toContainer() :
            throw new Exception("Array length less 1 is not allowed")},
        {"toString", nums => nums.Length >= 1 ? string.Join(" ", nums).toContainer() : // string.Join(" ", nums).toContainer() :
            throw new Exception("Array length less 1 is not allowed")},
        {"oddNumsArray", nums => nums.Length >= 1 ? nums.Where(n => n % 2 != 0).ToArray().toContainer() :
            throw new Exception("Array length less 1 is not allowed")}
    };

    public Numbers(string function, int[] nums)
    {
        try
        {
            Result = Functions[function](nums);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public Int32? getInteger()
    {
        return Result.Item1;
    }

    public Double? getDouble()
    {
        return Result.Item2;
    }

    public String? getString()
    {
        return Result.Item3;
    }

    public Array? getArray()
    {
        return Result.Item4;
    }
}
