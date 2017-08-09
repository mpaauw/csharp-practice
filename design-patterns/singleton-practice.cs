static void Main(string[] args)
{
    Singleton singleton = Singleton.getInstance();
    singleton.testInstance();
    singleton = Singleton.getInstance();
    Singleton singletonSequel = Singleton.getInstance();
}

public class Singleton
{
    private static Singleton instance = null;

    private Singleton()
    {
        // cannot be instantiated
    }

    public static Singleton getInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
            System.Diagnostics.Debug.WriteLine("Singleton created.");
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("Unable to get instance, one already exists.");
        }
        return instance;
    }

    public void testInstance()
    {
        System.Diagnostics.Debug.WriteLine("Singleton valid.");
    }
}