using ArrayLibrary;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 4, 0, 3, 19, 492, -10, 1 };

        Numbers numbers = new Numbers(new ArrayPreparer(nums));

        int sum = numbers.sumOfTwoMinNumbers();

        Console.WriteLine(sum);
    }
}