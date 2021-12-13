using System;

namespace ArrayLibrary;

public class Numbers
{
    public int? Result;
    private Dictionary<string, Func<int[], int>> Funcs = new Dictionary<string, Func<int[], int>>
    {
        {"sum2MinNums", nums => nums.Length >= 2 ? nums.OrderBy(n => n).Take(2).Sum() :
            throw new Exception("Array length less 2 is not allowed")},
        {"sumEvenNums", nums => nums.Length >= 1 ? nums.Where(n => n % 2 == 0).Sum() :
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
}
