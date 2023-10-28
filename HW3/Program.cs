namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Fedor", DateTime.Parse("01.01.2010"), 220);
            Person son = new Person("Max", DateTime.Parse("01.01.2000"), 180);
            Person daughter = new Person("Rita", DateTime.Parse("01.01.2000"), 160);
            Person father = new Person("Dima", DateTime.Parse("18.07.1980"), 213);
            Person mother = new Person("Anna", DateTime.Parse("09.03.1985"), 195);

            person1.AddFamilyInfo(father, mother, daughter, son);
            person1.PrintFamilyInfo();

            var res = person1.GetChildren(out Person[] children);
            if (res == true)
            {
                Console.WriteLine("Дети есть");
            }
        }
    }
    class Person
    {
        public readonly string Name = String.Empty;
        public readonly DateTime Birthday;
        public readonly int Height;
        public Person Father = null;
        public Person Mother = null;
        public Person[] Children = null;

        public Person(string name, DateTime BirthDay, int height)
        {
            this.Name = name;

            if (BirthDay <= DateTime.Now)
            {
                this.Birthday = BirthDay;
            }
            else
            {
                Console.WriteLine($"Дата {BirthDay}, не верна! Присваиваем дату по умолчанию - 01.01.1900");
                this.Birthday = DateTime.Parse("01.01.1900");

            }

            this.Height = height;
        }
        public void Print()
        {
            Console.WriteLine($"Имя = {Name}, ДР = {Birthday}, Рост = {Height}");
        }
        public void PrintFamilyInfo()
        {
            if (Father != null)
            {
                Console.WriteLine("Отец: ");
                Father.Print();
            }
            if (Mother != null)
            {
                Console.WriteLine("Мать: ");
                Mother.Print();
            }
            if (Children != null && Children.Length > 0)
            {
                Console.WriteLine("Дети: ");
                foreach (var child in Children)
                {
                    child.Print();
                }
            }
        }
        public bool IsAdult(int adultAge = 18)
        {
            var delta = DateTime.Now.Year - Birthday.Year;
            if (delta > adultAge || (delta == adultAge && DateTime.Now.DayOfYear <= adultAge))
            {
                return true;
            }
            return false;
        }
        public void AddFamilyInfo(Person father, Person mother, params Person[] children)
        {
            Father = father;
            Mother = mother;
            Children = children;
        }
        public bool GetChildren(out Person[] children)
        {
            if (Children != null && Children.Length != 0)
            {
                children = Children;
                return true;
            }
            else
            {
                children = null;
                return false;
            }
        }
    }
}