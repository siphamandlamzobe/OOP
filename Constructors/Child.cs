namespace Constructors;

public class Child : Person
{
    private static int maximumAge;
    private static string first;
    private static string last;
    public Child(string lastName, string firstName) : base(lastName, firstName)
    {
        first = firstName;
        last = lastName;
    }

    static Child() => maximumAge = 18;

    public void ChildMaxAge()
    {
        Console.WriteLine($"Child's max age {maximumAge}");
    }

    public string GetChildNames()
    {
        return $"{first} {last}";
    }
}
