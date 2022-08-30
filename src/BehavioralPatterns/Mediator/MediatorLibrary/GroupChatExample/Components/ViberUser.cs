using MediatorLibrary.GroupChatExample.Components.Common;

namespace MediatorLibrary.GroupChatExample.Components;

public class ViberUser : User
{
    public ViberUser(string name)
        : base(name)
    {
    }

    public override void Receive(string message) =>
        Console.WriteLine($"{_name} received the message: '{message}'");

    public override void Send(string message)
    {
        if (_mediator == null)
        {
            return;
        }

        Console.WriteLine($"{_name} is sending the message: '{message}' to the group");
        _mediator.SendMessage(message, this);
    }
}
