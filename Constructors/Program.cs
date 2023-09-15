namespace Constructors;

internal class Program
{
    static void Main(string[] args)
    {
        Child child = new Child("Carl", "Thomas");
        child.ChildMaxAge();

        var childFullNames = child.GetChildNames();
        Console.WriteLine($"The child's name {childFullNames}");
    }
}