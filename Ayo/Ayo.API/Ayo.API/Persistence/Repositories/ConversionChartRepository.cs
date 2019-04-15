using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ayo.API.Domain.Models;
using Ayo.API.Domain.Repositories;
using Ayo.API.Persistence.Contexts;

namespace Ayo.API.Persistence.Repositories
{
    public class ConversionChartRepository : BaseRepository, IConversionChartRepository
    {
        public ConversionChartRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ConversionChart>> ListAsync()
        {
            return await _context.ConversionCharts.Include(p => p.Category).ToListAsync();
        }

        public async Task AddAsync(ConversionChart conversionChart)
        {
            await _context.ConversionCharts.AddAsync(conversionChart);
        }

        public async Task<ConversionChart> FindByIdAsync(int id)
        {
            return await _context.ConversionCharts.FindAsync(id);
        }

    }
}