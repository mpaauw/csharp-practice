static void Main(string[] args)
{
    string mutableTestPhrase = "Hello, World!";
    string testPhrase = "foobar";
    System.Diagnostics.Debug.WriteLine(mutableTestPhrase);
    System.Diagnostics.Debug.WriteLine(testPhrase);
    stringModifier(ref mutableTestPhrase, testPhrase);
    System.Diagnostics.Debug.WriteLine(mutableTestPhrase); // mutable input has been changed within the called method via ref
    System.Diagnostics.Debug.WriteLine(testPhrase); // regular input was not changed despite reassignment within the called method, due to an absent ref parameter
}

public static void stringModifier(ref string mutableInput, string input)
{
    mutableInput = "Mutable input changed.";
    input = "Input changed.";
}