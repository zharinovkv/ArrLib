namespace ArrayLibrary;

public class Numbers
{
    private string Result;

    private Dictionary<string, Func<int[], int, string>> Funcs =
        new Dictionary<string, Func<int[], int, string>>
    {
        {"sum2MinNums", (nums, slice) => isValidArray(nums, 2) ?
            nums.OrderBy(n => n).Take(2).Sum().ToString() : ""},
        {"sumSliceNums", (nums, slice) => isValidArray(nums, slice) ?
            nums.Take(slice).Sum().ToString() : ""},
        {"averageNums", (nums, slice) => isValidArray(nums, 1) ?
            nums.Average().ToString() : ""},
        {"toString", (nums, slice) => isValidArray(nums, 1) ?
            string.Join(" ", nums).ToString() : ""},
        {"oddNums", (nums, slice) => isValidArray(nums, 1) ?
            String.Join(", ", nums.Where(n => n % 2 != 0).ToArray()) : ""}
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

    public string getValue()
    {
        return this.Result;
    }

}

