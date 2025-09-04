namespace GradesApp
{
    /// <summary>
    /// Λαμβάνει ως είσοδο total marks και courses count
    /// και υπολογίζει τον μέσο όρο καθώς και παρουσιάζει
    /// αντίστοιχους χαρακτηρισμούς (Άριστα, Πολύ καλά, κλπ.)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double average;

            Console.WriteLine("Enter total marks and courses count.");

            if (!int.TryParse(Console.ReadLine(), out int totalMarks) || totalMarks < 0)
            {
                Console.WriteLine("Invalid input for total marks.");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int coursesCount) || coursesCount <= 0)
            {
                Console.WriteLine("Invalid input for courses count.");
                return;
            }

            average = (double)totalMarks / coursesCount;

            if (average < 0 || average > 10)
            {
                Console.WriteLine("The average must not be lesser than 0 or grater than 10.");
            }

            switch (average)
            {
                case >= 9.0 and <= 10.0:
                    Console.WriteLine($"Average: {average:F2} - Άριστα");
                    break;
                case >= 7.0 and < 9.0:
                    Console.WriteLine($"Average: {average:F2} - Πολύ καλά");
                    break;
                case >= 5.0 and < 7.0:
                    Console.WriteLine($"Average: {average:F2} - Καλά");
                    break;
                case >= 4.0 and < 5.0:
                    Console.WriteLine($"Average: {average:F2} - Μέτρια");
                    break;
                case >= 0.0 and < 4.0:
                    Console.WriteLine($"Average: {average:F2} - Ανεπιτυχώς");
                    break;
            }

        }
    }
}
