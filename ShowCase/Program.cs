using ArrayLibrary;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 4, 0, 3, 19, 492, -10, 1 };

        var numbers = new Numbers(new ArrayPreparer(nums), 2).Sum;

        try
        {
//            int sum = numbers.sumOfMinNumbers(2)(nums);
            Console.WriteLine(numbers);
        }
        catch (ArrayException ex)
        {
            Console.WriteLine($"Exception thrown {ex.Message}");
        }
    }
}