using PostingManagement.Application.Responses;

namespace PostingManagement.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommandResponse
    {
        public CreateCategoryCommandResponse()
        {

        }

        public CreateCategoryDto Category { get; set; }
    }
}