using OOApp.Model;

namespace OOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher alice = new Teacher();
            Teacher bob = new();
            var Kostas = new Teacher();

            Teacher anna = new Teacher()  //Object Initializer
            {
                Id = 1,
                Firstname = "Anna",
                Lastname = "Smith"
            };

            anna.Firstname = "Anna-Maria";
            Console.WriteLine(anna.Firstname);

            Teacher adnreas = new Teacher(2, "Andreas", "Doe");
        }
    }
}
