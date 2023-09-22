namespace SealedModifier;

public class SealedBase
{
    public virtual void DoSomething()
    {
        Console.WriteLine("Base Class");
    }
}

public class Derived : SealedBase
{
    public override sealed void DoSomething()
    {
        Console.WriteLine("Child Class");
    }
}

public class DerivedFromDerived : Derived
{
    public override void DoSomething() //can not override a sealed override method
    {
        Console.WriteLine("Chikd Class");
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}