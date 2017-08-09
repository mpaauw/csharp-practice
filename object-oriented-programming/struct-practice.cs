static void Main(string[] args)
{
    Bug spider = new cSharp_test.Program.Bug(8, 0, 10, "hairy");
    spider.buzz();
}

public struct Bug
{
    public int numLegs;
    public int numWings;
    public int numEyes;
    public string pattern;

    public Bug(int numLegs, int numWings, int numEyes, string pattern)
    {
        this.numLegs = numLegs;
        this.numWings = numWings;
        this.numEyes = numEyes;
        this.pattern = pattern;
    }

    public void buzz()
    {
        System.Diagnostics.Debug.WriteLine(numLegs + "\n" + numWings + "\n" + numEyes + "\n" + pattern);
    }
}