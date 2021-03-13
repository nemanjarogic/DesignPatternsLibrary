using MediatorLibrary.GroupChatExample.Mediators.Common;

namespace MediatorLibrary.GroupChatExample.Components.Common
{
    public abstract class User
    {
        protected IGroupChatMediator _mediator;
        protected string _name;

        public User(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public void SetMediator(IGroupChatMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Send(string message);

        public abstract void Receive(string message);
    }
}
