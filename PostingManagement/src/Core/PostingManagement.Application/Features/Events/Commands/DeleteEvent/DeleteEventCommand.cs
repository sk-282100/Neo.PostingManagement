using MediatR;
using System;

namespace PostingManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommand : IRequest
    {
        public string EventId { get; set; }
    }
}
