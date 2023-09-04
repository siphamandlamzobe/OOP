namespace Vihecles;

public class Car : Vehicle
{
    private int numberOfDoors;

    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        this.numberOfDoors = numberOfDoors;
    }

    public override void Start()
    {
        Console.WriteLine($"Starting the {year} {make} {model} car with {numberOfDoors} doors...");
    }

    public void Drive()
    {
        Console.WriteLine($"Driving the {year} {make} {model} car...");
    }
}
