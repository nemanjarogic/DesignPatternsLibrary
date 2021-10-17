using System;

namespace LazyLoadLibrary.VirtualProxyExample
{
    public class ProxyCollege : College
    {
        public ProxyCollege(int id)
        {
            Id = id;
            Console.WriteLine("College initialization completed.");
        }

        public override Library Library
        {
            get
            {
                if (base.Library == null)
                {
                    base.Library = new Library();
                }

                return base.Library;
            }
            set
            {
                base.Library = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is not College college)
            {
                return false;
            }

            return college.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
