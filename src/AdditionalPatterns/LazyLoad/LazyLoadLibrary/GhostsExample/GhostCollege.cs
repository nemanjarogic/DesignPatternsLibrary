using System;

namespace LazyLoadLibrary.GhostsExample
{
    /// <summary>
    /// A ghost is an object that is to be loaded in a partial state.
    /// It may only contain the object's identifier, but it loads its own data
    /// the first time one of its properties is accessed.
    /// It is a fake object that looks exactly like an object that you want to interact with,
    /// but is just an empty instance that gets all properties populated as soon as they are needed.
    /// Beware of ripple loading when using lazy load.
    /// </summary>
    public class GhostCollege : DomainObject
    {
        private string _missionStatement;
        private int _numberOfStudents;
        private Library _library;

        public GhostCollege(int id)
            : base(id)
        {
            Id = id;
            Console.WriteLine("College initialization completed.");
        }

        public string MissionStatement
        {
            get
            {
                LoadIfNecessary();
                return _missionStatement;
            }
            set
            {
                _missionStatement = value;
            }
        }

        public int NumberOfStudents
        {
            get
            {
                LoadIfNecessary();
                return _numberOfStudents;
            }
            set
            {
                _numberOfStudents = value;
            }
        }

        public Library Library
        {
            get
            {
                LoadIfNecessary();
                return _library;
            }
            set
            {
                _library = value;
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine(
                $"College mission statement is: '{MissionStatement}'.\n" +
                $"The college owns library with {Library.NumberOfBooks} books that " +
                $"was established on {Library.EstablishmentDate.ToShortDateString()}.");
        }

        protected override object[] FetchData()
        {
            return new object[3]
            {
                "Learn, Discover, Heal, Create, and Make the World Ever Better",
                850,
                new Library(),
            };
        }

        protected override void ApplyLoadedData(object[] dataRow)
        {
            Console.WriteLine("Loading data...");

            _missionStatement = (string)dataRow[0];
            _numberOfStudents = (int)dataRow[1];
            _library = (Library)dataRow[2];
        }
    }
}
