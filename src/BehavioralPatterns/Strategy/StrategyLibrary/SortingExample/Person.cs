namespace StrategyLibrary.SortingExample
{
    public class Person
    {
        public Person(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {YearOfBirth}";
        }
    }
}
