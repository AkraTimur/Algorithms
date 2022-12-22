namespace Fractal
{
    public class Fractal
    {
        public static ulong Factorial(int n)
        {
            if (n == 0) return 1;
            else return (ulong)n * Factorial(n - 1);

        }
    }
}
