namespace Lec1
{
    internal class Program
    {
        class Person
        {
            public string Name = String.Empty;
            public DateTime Birthday;
            public int Height;
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Vasya";
            person.Birthday = DateTime.Parse("01.05.2000");
            person.Height = 190;

            Console.WriteLine($"{person.Name},{person.Birthday}, {person.Height}");
        }
    }


}