using MediatorLibrary.GroupChatExample.Components.Common;

namespace MediatorLibrary.GroupChatExample.Mediators.Common
{
    public interface IGroupChatMediator
    {
        void AddParticipant(User user);

        void SendMessage(string message, User sender);
    }
}
