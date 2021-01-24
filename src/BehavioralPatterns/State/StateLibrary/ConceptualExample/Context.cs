using System;
using StateLibrary.ConceptualExample.States.Common;

namespace StateLibrary.ConceptualExample
{
    /// <summary>
    /// The Context defines the interface of interest to clients.
    /// It also maintains a reference to an instance of a State subclass,
    /// which represents the current state of the Context.
    /// </summary>
    public class Context
    {
        /// <summary>
        /// A reference to the current state of the Context.
        /// </summary>
        private State _state = null;

        public Context(State state)
        {
            TransitionTo(state);
        }

        /// <summary>
        /// The Context allows changing the State object at runtime.
        /// </summary>
        /// <param name="state">State.</param>
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        /// <summary>
        /// The Context delegates part of its behavior to the current State object.
        /// </summary>
        public void Request1()
        {
            _state.Handle1();
        }

        public void Request2()
        {
            _state.Handle2();
        }
    }
}
