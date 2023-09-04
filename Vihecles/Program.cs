namespace Vihecles;

internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Camry", 2022, 4);
        Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2021);

        car.Start();
        car.Drive();
        car.Stop();

        motorcycle.Start();
        motorcycle.Ride();
        motorcycle.Stop();
        
    }
}