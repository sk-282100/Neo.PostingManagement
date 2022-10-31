using PostingManagement.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace PostingManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}
