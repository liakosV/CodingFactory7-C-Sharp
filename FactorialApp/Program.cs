using System.Numerics;

namespace FactorialApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i,3}! = {FactoIterative(i):N0}");
                //Console.WriteLine($"Factorial of {i} (recursive) is {FactoRecursive(i)}");
            }
        }

        /// <summary>
        /// Iterative version of factorial calculation
        /// </summary>
        /// <param name="n">The input number</param>
        /// <returns>The result of factiorial</returns>
        public static BigInteger FactoIterative(int n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static BigInteger FactoRecursive(int n)
        {
            //if (n == 0)
            //{
            //    return 1;
            //}
            //return n * FactoRecursive(n - 1);

            return n == 0 ? 1 : n * FactoRecursive(n - 1);
        }
    }
}
