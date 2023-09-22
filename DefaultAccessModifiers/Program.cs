namespace DefaultAccessModifiers
{
    class ClassAtNamespaceLevel //internal
    {
        int number; //private
        class NestedClass //private by default
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}