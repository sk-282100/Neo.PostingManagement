using MediatR;
using PostingManagement.Application.Responses;
using System.Collections.Generic;

namespace PostingManagement.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<Response<IEnumerable<CategoryListVm>>>
    {
    }
}
