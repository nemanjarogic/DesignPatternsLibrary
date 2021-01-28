using System;

namespace TemplateMethodLibrary.ConceptualExample
{
    /// <summary>
    /// The Abstract Class defines a template method that contains a skeleton of
    /// some algorithm, composed of calls to (usually) abstract primitive operations.
    /// Concrete subclasses should implement these operations, but leave the template method itself intact.
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// The template method defines the skeleton of an algorithm.
        /// </summary>
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperations1();
            Hook1();

            BaseOperation2();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        /// <summary>
        /// These operations already have implementations.
        /// </summary>
        protected virtual void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        protected virtual void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        protected virtual void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        /// <summary>
        /// These operations have to be implemented in subclasses.
        /// </summary>
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        /// <summary>
        /// These are "hooks." Subclasses may override them, but it's not mandatory
        /// since the hooks already have default (but empty) implementation.
        /// Hooks provide additional extension points in some crucial places of the algorithm.
        /// </summary>
        protected virtual void Hook1()
        {
        }

        protected virtual void Hook2()
        {
        }
    }
}
