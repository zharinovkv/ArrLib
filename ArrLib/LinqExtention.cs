namespace ArrayLibrary;

public static class LinqExtention
{
    public static Tuple<int?, double?, string?, int[]?> toTuple(this int value)
    {
        return Tuple.Create<int?, double?, string?, int[]?>(value, null, null, null);
    }

    public static Tuple<int?, double?, string?, int[]?> toTuple(this double value)
    {
        return Tuple.Create<int?, double?, string?, int[]?>(null, value, null, null);
    }

    public static Tuple<int?, double?, string?, int[]?> toTuple(this string value)
    {
        return Tuple.Create<int?, double?, string?, int[]?>(null, null, value, null);
    }

    public static Tuple<int?, double?, string?, int[]?> toTuple(this int[] value)
    {
        return Tuple.Create<int?, double?, string?, int[]?>(null, null, null, value);
    }
}