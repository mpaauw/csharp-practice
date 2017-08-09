static void Main(string[] args)
{
    TripAdvisor roadTrippin = new TripAdvisor();
    System.Diagnostics.Debug.WriteLine(roadTrippin.calculateCostPerMile());
}

public class TripAdvisor
{
    private double gasCostPerGallon = 2.99;
    private double costOfRentalCar = 120.95;

    public double calculateCostPerMile()
    {
        return (costOfRentalCar / RoadTrippedCar.getOdometer()) + (gasCostPerGallon / RoadTrippedCar.calculateAverageMPG());
    }
}

public class RoadTrippedCar
{
    private static int odometer = 384;
    private static int gasTankCapacityInGallons = 12;
    private static int gasRemainingInGallons = 3;

    public static double calculateAverageMPG()
    {
        return odometer / (gasTankCapacityInGallons - gasRemainingInGallons);
    }

    public static int getOdometer()
    {
        return odometer;
    }
}