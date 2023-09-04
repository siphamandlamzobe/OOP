namespace Vihecles;

public class Vehicle
{
    protected string make;
    protected string model;
    protected int year;

    public Vehicle(string make, string model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting the {year} {make} {model}...");
    }

    public virtual void Stop() {
        Console.WriteLine($"Stopping the {year} {make} {model}...");
    }
}
