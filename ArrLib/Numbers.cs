namespace ArrayLibrary;

public class Numbers
{
    public double Result;

    private Dictionary<string, Func<int[], double>> Funcs = new Dictionary<string, Func<int[], double>>{
        {"min2sum", min2sum },
        {"max3average", max3average },
        {"evenSum", evenSum }
    };

    public Numbers(string func, int[] nums)
    {
        try
        {
            Result = Funcs[func](nums);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception  \"Operation not found by reason: {ex.Message}\"");
        }
    }

    static double min2sum(int[] nums)
    {
        if (nums.Length < 2)
        {
            throw new Exception("Array length less 2 is not allowed");
        }

        return nums.OrderBy(n => n).Take(2).Sum();
    }
    static double max3average(int[] nums)
    {
        if (nums.Length < 3)
        {
            throw new Exception("Array length less 3 is not allowed");
        }

        return nums.OrderByDescending(n => n).Take(3).Average();
    }
    static double evenSum(int[] nums)
    {
        if (nums.Length < 1)
        {
            throw new Exception("Array length less 1 is not allowed");
        }

        return nums.Where(n => n % 2 == 0).Sum();
    }
}
