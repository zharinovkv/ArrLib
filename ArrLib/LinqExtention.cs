namespace ArrayLibrary;

public static class LinqExtention
{
    public static DataContainer toContainer(this int value)
    {
        DataContainer dataContainer = new DataContainer();
        dataContainer.intValue = value;
        return dataContainer;
    }

    public static DataContainer toContainer(this double value)
    {
        DataContainer dataContainer = new DataContainer();
        dataContainer.doubleValue = value;
        return dataContainer;
    }

    public static DataContainer toContainer(this string value)
    {
        DataContainer dataContainer = new DataContainer();
        dataContainer.stringValue = value;
        return dataContainer;
    }

    public static DataContainer toContainer(this int[] value)
    {
        DataContainer dataContainer = new DataContainer();
        dataContainer.arrayValue = value;
        return dataContainer;
    }

}