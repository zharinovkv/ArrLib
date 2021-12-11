using ArrayLibrary;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 4, 0, 3, 19, 492, -10, 1 };

        var result = new Numbers("min2sum", nums).Result;

        Console.WriteLine(result);
    }
}
