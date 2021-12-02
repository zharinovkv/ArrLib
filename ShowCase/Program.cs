using ArrayLibrary;

class Program
{
    static void Main(string[] args)
    {
        //int[] nums = { 4, 0, 3, 19, 492, -10, 1 };

//        int[] nums = { };

        int[] nums = new int[] { };



        Numbers numbers = new Numbers(new ArrayPreparer(nums));

        int sum = numbers.sumTwoMinNumbers();

        Console.WriteLine(sum);
    }
}