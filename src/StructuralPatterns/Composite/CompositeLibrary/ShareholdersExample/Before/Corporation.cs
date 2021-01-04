using System.Collections.Generic;

namespace CompositeLibrary.ShareholdersExample.Before
{
    public class Corporation
    {
        public Corporation()
        {
            Shareholders = new List<Person>();
        }

        public string Name { get; set; }

        public List<Person> Shareholders { get; set; }
    }
}
