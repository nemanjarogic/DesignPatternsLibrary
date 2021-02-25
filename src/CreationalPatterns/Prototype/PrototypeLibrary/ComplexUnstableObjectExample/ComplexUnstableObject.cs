using System;

namespace PrototypeLibrary.ComplexUnstableObjectExample
{
    /// <summary>
    /// This class kind of represents an object that you might create that is going to be unstable
    /// because you might be changing it a lot, especially the constructors, and fairly complicated.
    /// Maybe it's difficult to construct this object and there's a reason why you have a large 
    /// number of constructors, and it's part of some framework that you're building.
    /// This is going to happen a lot of times when you're trying to make a simple API for users, to use your
    /// framework or to use some library that you're creating, but internally there's a lot of complexity.
    /// So in this case you can see, I've basically just set up this class to have a few constructors here
    /// that take a lot of parameters, that aren't very well named, and can be very complicated to set up and
    /// know when to call what constructor. And we don't have any implementation here, but you can imagine
    /// that there might be some complex implementation of what these constructors actually do.
    /// </summary>
    public class ComplexUnstableObject : ICloneable
    {
        internal ComplexUnstableObject(string a, int b, int c, char d, string e)
        {
        }

        internal ComplexUnstableObject(int ba, int c, char d, string e)
        {
        }

        internal ComplexUnstableObject(string a, char da, string e)
        {
        }

        internal ComplexUnstableObject(string a, int c, char d, string e, string f)
        {
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
