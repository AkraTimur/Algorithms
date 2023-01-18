namespace Log2n
{
    public class Program
    {
        static void Main(string[] args)
        {
            Log2n(8);
        }
        public static void Log2n(int n)
        {
            double log = Math.Log(n) / Math.Log(2);
            Console.WriteLine($"log2({n}) = {log}");
        }
    }   
}