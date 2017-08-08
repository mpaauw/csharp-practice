static void Main(string[] args)
{
    Car[] cars =
    {
        new cSharp_test.Program.Car("Ford", 1000),
        new cSharp_test.Program.Car("Volkswagen", 5000),
        new cSharp_test.Program.Car("Volvo", 8000),
        new cSharp_test.Program.Car("Audi", 10000),
        new cSharp_test.Program.Car("Tesla", 20000),
        new cSharp_test.Program.Car("Ferrari", 200000)
    };

    printModelsAbovePrice(9000, cars);
}

public static void printModelsAbovePrice(int price, Car[] carList)
{
    IEnumerable<Car> expensiveCars =
        from car in carList
        where car.cost > price
        select car;

    foreach(Car car in expensiveCars)
    {
        System.Diagnostics.Debug.WriteLine("Model: [" + car.model + "]");
    }
}

public class Car
{
    public string model;
    public int cost;

    public Car(string model, int cost)
    {
        this.model = model;
        this.cost = cost;
    }
}