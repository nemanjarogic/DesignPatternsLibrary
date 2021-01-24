using System;
using StateLibrary.ConceptualExample.States.Common;

namespace StateLibrary.ConceptualExample.States
{
    public class ConcreteStateB : State
    {
        public override void Handle1()
        {
            Console.Write("ConcreteStateB handles request1.");
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateB handles request2.");
            Console.WriteLine("ConcreteStateB wants to change the state of the context.");

            _context.TransitionTo(new ConcreteStateA());
        }
    }
}
