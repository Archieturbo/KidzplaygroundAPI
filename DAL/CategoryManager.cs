﻿using Microsoft.EntityFrameworkCore;
namespace KidzplaygroundAPI.DAL
{
    public class CategoryManager
    {

        private readonly MyDbContext _dbContext;

        public CategoryManager(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<Models.Category>> GetCategories()
        {
            return await _dbContext.Categories.ToListAsync();
        }
    }
}
