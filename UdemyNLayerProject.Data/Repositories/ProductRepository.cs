﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyNLayerProject.Core.Models;
using UdemyNLayerProject.Core.Repositories;

namespace UdemyNLayerProject.Data.Repositories
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        private AppDbContext appDbContext
        {
            get => _context as AppDbContext;
        }
        public ProductRepository(DbContext context) : base(context)
        {
        }
        
        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync(x => x.Id == productId);
        }

       
    }
}