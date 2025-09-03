namespace ExpressionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 40;

            int sum = 0;
            int multiply = 1;
            int divide = 0;
            int mod = 0;

            int result1 = 0;
            int result2 = 0;
            int result3 = 0;

            sum = num1 + num2;
            multiply = num1 * num2;
            divide = num1 / num3;
            mod = num1 % num3;

            result1 = sum++;
            result1 = sum + 1;
            result2 = result2 + 5;
            result2 += 5;

            result3 = (num1 > 0) ? 1 : 0;
            result3 = Math.Abs(num3);
        }
    }
}
