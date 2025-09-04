using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello123";
            string pattern = @"\d+";
            GetOneMatch(input, pattern);

            string input2 = "price1: $10, price2: $20, price3: $30";
            string pattern2 = @"\$\d+";
            GetMultipleMatches(input2, pattern2);

            string input3 = "Phone Number is: 691-234-5678";
            string pattern3 = @"\d";
            string replacement = "*";
            Replaces(input3, pattern3, replacement);

            string input4 = "apple,banana,cherry,orange";
            string pattern4 = @",";
            Split(input4, pattern4);
        }

        public static void GetOneMatch(string input, string pattern)
        {
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void GetMultipleMatches(string input, string pattern)
        {
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Replaces(string input, string pattern, string replacement)
        {
            string replaced = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(replaced);
        }

        public static void Split(string input, string pattern)
        {
            string[] tokens = Regex.Split(input, pattern);
            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }
        }
    }
}
