namespace FiboIterativeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i,2} = {Fibo(i)}");
            }
        }

        public static int Fibo(int n)
        {
            int num1 = 0;
            int num2 = 1;
            int result = 1;

            for(int i = 1; i < n; i++)
            {
                result = num1 + num2;
                num1 = num2;
                num2 = result;
            }
            
            return (n != 0) ? result : 0;
        }
    }
}
