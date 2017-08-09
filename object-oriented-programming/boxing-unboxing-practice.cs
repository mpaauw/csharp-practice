static void Main(string[] args)
{
    List<object> boxedInts = boxIntegers(10);
    unboxIntegers(boxedInts);
}

public static void unboxIntegers(List<object> boxedInts)
{
    foreach (object o in boxedInts)
    {
        int value = (int)o;
        System.Diagnostics.Debug.WriteLine(value); // no runtime error should be thrown
    }
}

public static List<object> boxIntegers(int numInts)
{
    List<object> objectList = new List<object>();
    for (int i = 0; i < numInts; i++)
    {
        objectList.Add(i);
    }
    return objectList;
}