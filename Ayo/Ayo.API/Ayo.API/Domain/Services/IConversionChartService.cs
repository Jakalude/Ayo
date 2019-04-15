using System.Collections.Generic;
using System.Threading.Tasks;
using Ayo.API.Domain.Models;

namespace Ayo.API.Domain.Services
{
    public interface IConversionChartService
    {
        Task<IEnumerable<ConversionChart>> ListAsync();
        Task<ConversionChart> FindByIdAsync(int id);

    }
}
