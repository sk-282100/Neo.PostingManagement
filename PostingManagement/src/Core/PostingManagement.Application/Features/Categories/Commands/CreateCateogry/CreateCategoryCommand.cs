using MediatR;
using PostingManagement.Application.Responses;

namespace PostingManagement.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommand : IRequest<Response<CreateCategoryDto>>
    {
        public string Name { get; set; }
    }
}
