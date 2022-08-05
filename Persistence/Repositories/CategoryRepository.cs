using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Repositories;
using api_rest.Domain.Models;
using api_rest.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;

namespace api_rest.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRespository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}

