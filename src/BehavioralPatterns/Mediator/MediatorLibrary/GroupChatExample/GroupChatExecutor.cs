using System;
using BuildingBlocks;
using MediatorLibrary.GroupChatExample.Components;
using MediatorLibrary.GroupChatExample.Mediators;
using MediatorLibrary.GroupChatExample.Mediators.Common;

namespace MediatorLibrary.GroupChatExample
{
    public static class GroupChatExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Group chat example");

            var mark = new ViberUser("Mark");
            var jane = new ViberUser("Jane");
            var emily = new ViberUser("Emily");
            var anna = new ViberUser("Anna");

            IGroupChatMediator mediator = new ViberGroupChatMediator(
                mark,
                jane,
                emily);

            mark.Send("Is anyone there?");

            Console.WriteLine();
            mediator.AddParticipant(anna);

            emily.Send("We are here.");

            // You can see an alternative approach how to setup mediator and components
            // Third approach can be seen in air trafic control example

            // var mark = new ViberUser("Mark", mediator);
            // IGroupChatMediator mediator = new ViberGroupChatMediator();
            // mediator.AddParticipant(mark);
        }
    }
}
