using AutoMapper;
using MoneyTracker.Domain.Entities;

namespace MoneyTracker.Application.Dtos.Categories;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, GetCategoryDto>();
        CreateMap<Account, GetAccountWCategoryDto>();
        CreateMap<CreateCategoryDto, Category>();
    }
}
