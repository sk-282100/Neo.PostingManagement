using AutoMapper;
using PostingManagement.Application.Features.Categories.Commands.CreateCateogry;
using PostingManagement.Application.Features.Categories.Queries.GetCategoriesList;
using PostingManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using PostingManagement.Application.Features.Events.Commands.CreateEvent;
using PostingManagement.Application.Features.Events.Commands.UpdateEvent;
using PostingManagement.Application.Features.Events.Queries.GetEventDetail;
using PostingManagement.Application.Features.Events.Queries.GetEventsExport;
using PostingManagement.Application.Features.Events.Queries.GetEventsList;
using PostingManagement.Application.Features.Orders.Queries.GetOrdersForMonth;
using PostingManagement.Domain.Entities;

namespace PostingManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();
        }
    }
}
