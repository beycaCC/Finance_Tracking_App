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
        CreateMap<UpdateCategoryDto, Category>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())
            .ForMember(dest => dest.Accounts, opt => opt.Ignore());
    }
}
