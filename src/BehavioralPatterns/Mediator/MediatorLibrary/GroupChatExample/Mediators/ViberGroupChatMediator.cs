using MediatorLibrary.GroupChatExample.Components.Common;
using MediatorLibrary.GroupChatExample.Mediators.Common;

namespace MediatorLibrary.GroupChatExample.Mediators;

public class ViberGroupChatMediator : IGroupChatMediator
{
    private readonly List<User> _chatParticipants = new();

    public ViberGroupChatMediator(params User[] users)
    {
        foreach (var user in users)
        {
            AddParticipant(user);
        }

        Console.WriteLine();
    }

    public void AddParticipant(User user)
    {
        Console.WriteLine($"{user.Name} is a new chat participant.");

        _chatParticipants.Add(user);
        user.SetMediator(this);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _chatParticipants.Where(user => user != sender))
        {
            user.Receive(message);
        }
    }
}
