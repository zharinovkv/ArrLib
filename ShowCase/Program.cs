using ArrayLibrary;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 4, 0, 3, 19, 492, -10, 1 };

        Numbers numbers = new Numbers("sum2MinNums", nums);

        Console.WriteLine(numbers.getInteger());

        Console.WriteLine(new Numbers("toString", nums).getString());
    }
}
