using System.Collections.Generic;
using System.Threading.Tasks;
using Ayo.API.Domain.Models;
using Ayo.API.Domain.Services.Communication;

namespace Ayo.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        //Task<SaveCategoryResponse> SaveAsync(Category category);
        //Task<SaveCategoryResponse> UpdateAsync(int id, Category category);

    }
}