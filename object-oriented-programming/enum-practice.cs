static void Main(string[] args)
{
    printMonths();
}

public static void printMonths()
{
    Array monthNames = Enum.GetNames(typeof(Months));

    for(int i = 0; i < 12; i++)
    {
        System.Diagnostics.Debug.WriteLine(monthNames.GetValue(i));
    }
}

public enum Months
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}