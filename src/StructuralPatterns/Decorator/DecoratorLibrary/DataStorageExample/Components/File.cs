using System;
using System.Text;
using DecoratorLibrary.DataStorageExample.Components.Common;

namespace DecoratorLibrary.DataStorageExample.Components
{
    /// <summary>
    /// Concrete components provide default implementations for the operations.
    /// There might be several variations of these classes in a program.
    /// </summary>
    public class File : IDataSource
    {
        private readonly string _name;
        private StringBuilder _data;

        public File(string name)
        {
            _name = name;
            _data = new StringBuilder();
        }

        public void ClearContent()
        {
            _data.Clear();
        }

        public string Read()
        {
            return _data.ToString();
        }

        public void Write(string data)
        {
            _data.Append(data);

            Console.WriteLine($"Written: {data}");
        }
    }
}
