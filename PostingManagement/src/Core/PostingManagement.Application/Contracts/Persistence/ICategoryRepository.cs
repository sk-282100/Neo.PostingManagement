using PostingManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostingManagement.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}
