using System.Collections.Generic;
using System.Threading.Tasks;
using Ayo.API.Domain.Models;

namespace Ayo.API.Domain.Repositories
{
    public interface IConversionChartRepository
    {

        Task<IEnumerable<ConversionChart>> ListAsync();
        Task AddAsync(ConversionChart conversionChart);
        Task<ConversionChart> FindByIdAsync(int id);
    }
}
