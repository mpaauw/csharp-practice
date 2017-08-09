static void Main(string[] args)
{
    Bible bible = new Bible(true, 9);
    System.Diagnostics.Debug.WriteLine(bible.timeToReadInSeconds(2000, 120, 8));

    Brochure brochure = new Brochure(5);
    System.Diagnostics.Debug.WriteLine(brochure.timeToReadInSeconds(5, 30, 14));
}

public class Bible : Book
{
    private bool isTranslated;
    private int complexityFactor;

    public Bible(bool isTranslated, int complexityFactor)
    {
        this.isTranslated = isTranslated;
        this.complexityFactor = complexityFactor;
    }

    public double timeToReadInSeconds(int numPages, double secondsPerPage, int fontSize)
    {
        return (isTranslated) ? (numPages * secondsPerPage) + (secondsPerPage / fontSize) * complexityFactor : double.MaxValue;
    }
}

public class Brochure : Book
{
    private int numIllustrations;

    public Brochure(int numIllustrations)
    {
        this.numIllustrations = numIllustrations;
    }

    public double timeToReadInSeconds(int numPages, double secondsPerPage, int fontSize)
    {
        return (numPages * secondsPerPage) + (secondsPerPage / fontSize) - (numIllustrations * secondsPerPage);
    }
}

public interface Book
{
    double timeToReadInSeconds(int numPages, double secondsPerPage, int fontSize);
}