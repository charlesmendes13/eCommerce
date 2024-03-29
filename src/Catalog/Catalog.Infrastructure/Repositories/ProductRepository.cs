﻿using Catalog.Domain.Interfaces.Repositories;
using Catalog.Domain.Models;
using Catalog.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CatalogContext _context;

        public ProductRepository(CatalogContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetListAsync()
        {
            try
            {
                return await _context.Product
                    .Where(x => x.Active)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Product
                    .Where(x => x.Id == id && x.Active)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
