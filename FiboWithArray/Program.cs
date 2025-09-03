namespace FiboWithArray
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
            int[] fiboNumbers = new int[n + 1];
            fiboNumbers[0] = 0;
            if (n > 0)
            {
                fiboNumbers[1] = 1;
                for (int i = 2; i <= n; i++)
                {
                    fiboNumbers[i] = fiboNumbers[i - 1] + fiboNumbers[i - 2];
                }
            }
            return fiboNumbers[n];
        }
    }
}
