namespace ArrayLibrary;

public static class LinqExtention
{
    public static Tuple<Int32?, Double?, String?, Array?> toContainer(this int value)
    {
        return Tuple.Create<Int32?, Double?, String?, Array?>(value, null, null, null);
    }

    public static Tuple<Int32?, Double?, String?, Array?> toContainer(this double value)
    {
        return Tuple.Create<Int32?, Double?, String?, Array?>(null, value, null, null);
    }

    public static Tuple<Int32?, Double?, String?, Array?> toContainer(this string value)
    {
        return Tuple.Create<Int32?, Double?, String?, Array?>(null, null, value, null);
    }

    public static Tuple<Int32?, Double?, String?, Array?> toContainer(this Array value)
    {
        return Tuple.Create<Int32?, Double?, String?, Array?>(null, null, null, value);
    }
}