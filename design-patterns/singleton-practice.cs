public class Singleton {

    private static Singleton instance = null;

    private Singleton() {
        // cannot be instantiated
    }

    public static Singleton getInstance() {
        if(this.instance == null) {
            return this.instance.getInstance();
        }
    }
}