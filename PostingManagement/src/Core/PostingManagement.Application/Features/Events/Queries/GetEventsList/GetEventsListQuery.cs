using MediatR;
using PostingManagement.Application.Responses;
using System.Collections.Generic;

namespace PostingManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery : IRequest<Response<IEnumerable<EventListVm>>>
    {

    }
}
