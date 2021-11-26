namespace UtilityLibraries;

public static class ArrLib
{
    public static int calcSumMinElements(int[] grade, int take = 2)
    {
        return grade.OrderBy(g => g).Take(take).Sum();
    }
}