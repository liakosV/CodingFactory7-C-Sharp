namespace ReadApp
{
    /// <summary>
    /// Read two integers from the console and print their sum.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int result;

            Console.WriteLine("Please insert two integers.");
            num1 = int.Parse(Console.ReadLine()!);
            num2 = int.Parse(Console.ReadLine()!);
            result = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {result}");
        }
    }
}
