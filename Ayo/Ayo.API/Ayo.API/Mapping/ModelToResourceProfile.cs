using AutoMapper;
using Ayo.API.Domain.Models;
using Ayo.API.Resources;

namespace Ayo.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<ConversionChart, ConversionChartResource>();
        }
    }
}
