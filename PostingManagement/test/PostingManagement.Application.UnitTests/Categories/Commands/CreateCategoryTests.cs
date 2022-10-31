using AutoMapper;
using Moq;
using PostingManagement.Application.Contracts.Persistence;
using PostingManagement.Application.Features.Categories.Commands.CreateCateogry;
using PostingManagement.Application.Profiles;
using PostingManagement.Application.UnitTests.Mocks;
using PostingManagement.Domain.Entities;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace PostingManagement.Application.UnitTests.Categories.Commands
{
    public class CreateCategoryTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICategoryRepository> _mockCategoryRepository;

        public CreateCategoryTests()
        {
            _mockCategoryRepository = CategoryRepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mapper, _mockCategoryRepository.Object);

            await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsync();
            allCategories.Count.ShouldBe(5);
        }


        [Fact]
        public async Task Handle_InValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new CreateCategoryCommand() { Name = "" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsync();
            allCategories.Count.ShouldBe(4);
            result.Errors.Count.ShouldNotBe(0);
            result.Succeeded.ShouldBe(false);
        }
    }
}
