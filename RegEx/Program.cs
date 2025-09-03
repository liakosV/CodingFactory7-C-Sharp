using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello123";
            string pattern = @"^[A-Z]+\d+";
            ExactMatch(input, pattern);
        }

        public static void ExactMatch(string input, string pattern)
        {
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
