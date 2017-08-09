static void Main(string[] args)
{
    Owl archimedes = new cSharp_test.Program.Owl("Screeeeech", 6.5, 4, true);
    System.Diagnostics.Debug.WriteLine(archimedes.howScaredShouldIBe());
}

public class Owl : Bird
{
    string callSound;
    double wingSpanInFt;
    int numberOfMiceEaten;

    public Owl(string callSound, double wingSpanInFt, int numberOfMiceEaten, bool isDangerous) : base(isDangerous)
    {
        this.callSound = callSound;
        this.wingSpanInFt = wingSpanInFt;
        this.numberOfMiceEaten = numberOfMiceEaten;
    }

    public override double howScaredShouldIBe()
    {
        double fearFactor = (callSound.Length * wingSpanInFt) - numberOfMiceEaten;
        return fearFactor * base.howScaredShouldIBe();
    }
}

public abstract class Bird
{
    public bool isDangerous;

    public Bird(bool isDangerous)
    {
        this.isDangerous = isDangerous;
    }

    public virtual double howScaredShouldIBe()
    {
        return (isDangerous) ? 2 : 1;
    }
}