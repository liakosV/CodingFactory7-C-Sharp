namespace PrimesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter a positive integer:");
            number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"{number} is prime: {IsPrime(number)}");
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
