﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ayo.API.Domain.Models;
using Ayo.API.Domain.Repositories;
using Ayo.API.Persistence.Contexts;

namespace Ayo.API.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }

        //public async Task UpdateAsync(Category category)
        //{
        //    await _context.Categories.AddAsync(category);
        //}
    }
}