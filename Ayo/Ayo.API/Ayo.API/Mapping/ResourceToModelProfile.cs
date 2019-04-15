using AutoMapper;
using Ayo.API.Domain.Models;
using Ayo.API.Resources;

namespace Ayo.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
