namespace Vihecles;

public class Motorcycle : Vehicle
{
    public Motorcycle(string make, string model, int year) : base(make, model, year)
    {
    }

    public override void Start()
    {
        Console.WriteLine($"Starting the {year} {model} {year} motorcycle...");
    }

    public void Ride()
    {
        Console.WriteLine($"Riding the {year} {model} {year} motorcycle...");
    }
}
