namespace OptionalParamsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = GetDateTime();
            Console.WriteLine($"{dateTime:F}");

            DateTime dateTimeNow = DateTime.Now;
            Console.WriteLine($"{dateTimeNow:F}");
        }

        public static DateTime GetDateTime(int year = 2025, int month = 8, int day = 1, int min = 0, int seconds = 0, int milli = 0)
        {
            return new DateTime(year, month, day, min, seconds, milli, DateTimeKind.Utc);
        }
    }
}
