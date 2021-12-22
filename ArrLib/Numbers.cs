namespace ArrayLibrary;

public class Numbers
{
    private Tuple<int?, double?, string?, int[]?>? Result;

    private Dictionary<string, Func<int[], int, Tuple<int?, double?, string?, int[]?>?>> Funcs =
        new Dictionary<string, Func<int[], int, Tuple<int?, double?, string?, int[]?>?>>
    {
        {"sum2MinNums", (nums, slice) => isValidArray(nums, 2) ?
            nums.OrderBy(n => n).Take(2).Sum().toTuple() :
            null},
        {"sumSliceNums", (nums, slice) => isValidArray(nums, slice) ?
            nums.Take(slice).Sum().toTuple() :
            null},
        {"averageNums", (nums, slice) => isValidArray(nums, 1) ?
            nums.Average().toTuple() :
            null},
        {"toString", (nums, slice) => isValidArray(nums, 1) ?
            string.Join(" ", nums).toTuple() :
            null},
        {"oddNumsArray", (nums, slice) => isValidArray(nums, 1) ?
            nums.Where(n => n % 2 != 0).ToArray().toTuple() :
            null}
    };

    public Numbers(string func, int[] nums, int slice = 0)
    {
        try
        {
            Result = Funcs[func](nums, slice);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static bool isValidArray(int[] nums, int? length = 0)
    {
        return nums.Length >= length ? true :
            throw new Exception($"Array length less {length} is not allowed");
    }

    public int? getItemInteger()
    {
        return Result.Item1;
    }

    public double? getItemDouble()
    {
        return Result.Item2;
    }

    public string? getItemString()
    {
        return Result.Item3;
    }

    public int[]? getItemArray()
    {
        return Result.Item4;
    }
}
