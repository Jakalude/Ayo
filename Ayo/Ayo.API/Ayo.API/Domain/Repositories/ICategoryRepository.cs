using System.Collections.Generic;
using System.Threading.Tasks;
using Ayo.API.Domain.Models;

namespace Ayo.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        //Task<Category> FindByIdAsync(int id);
        //void Update(Category category);
    }
}
