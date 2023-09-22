namespace ParamsKeyword
{
    internal class Program
    {
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3, 4));

            Console.WriteLine("Hello, World!");
        }
    }
}