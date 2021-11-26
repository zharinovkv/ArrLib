using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {

        int[] grade = {4, 0, 3, 19, 492, -10, 1};
        int result = ArrLib.calcSumMinElements(grade);
        Console.WriteLine(result);
    }
}