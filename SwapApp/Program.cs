namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Swap(a, b);
            Console.WriteLine($"a: {a}, b:{b}");

            SwapRef(ref a, ref b);
            Console.WriteLine($"With ref a: {a}, b: {b}");

            string s = null;
            ChangeStr(out s);
            Console.WriteLine(s);
        }

        public static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void SwapRef(ref int a, ref int b)
        {
            //int temp = a;
            //a = b;
            //b = temp;

            (a, b) = (b, a);
        }

        public static void ChangeStr(out string? str)
        {
            str = "AUEB";
        }
    }
}