using ArrayLibrary;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 4, 0, 3, 19, 492, -10, 1 };        

        Console.WriteLine(new Numbers("sum2MinNums", nums).getValue());
        Console.WriteLine(new Numbers("sumSliceNums", nums, 6).getValue());
        Console.WriteLine(new Numbers("averageNums", nums, 5).getValue());
        Console.WriteLine(new Numbers("toString", nums, 4).getValue());
        Console.WriteLine(new Numbers("oddNums", nums, 3).getValue());
    }
}

