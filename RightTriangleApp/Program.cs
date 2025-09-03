namespace RightTriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EPSILON = 0.000005;
            double a, b, c;
            bool isRight = false;

            Console.WriteLine("Please enter a, b, c");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Format Error. 'a' must be a double.");
            }
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Format Error. 'b' must be a double.");
            }
            if (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Format Error. 'c' must be a double.");
            }

            isRight = Math.Abs(a * a - b * b - c * c) <= EPSILON;
            Console.WriteLine("The triangle is{0}right", (isRight) ? " " : " not ");

        }
    }
}
