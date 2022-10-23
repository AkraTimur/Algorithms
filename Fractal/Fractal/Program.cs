namespace Fractal
{
    public static class Program
    {
        public static ulong Factorial(int n)
        {
            if (n == 0) return 1;
            else return (ulong)n * Factorial(n - 1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(0));
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(2));
            Console.WriteLine(Factorial(3));
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Factorial(5));

        }
    }
}