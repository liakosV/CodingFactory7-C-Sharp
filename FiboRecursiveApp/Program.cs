namespace FiboRecursiveApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i,2} = {Fibo(i)}");
            }
        }

        public static int Fibo(int n)
        {
            return (n <= 1) ? n : Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
