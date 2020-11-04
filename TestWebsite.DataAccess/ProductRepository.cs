using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestWebsite.DataAccess.Base;
using TestWebsite.Entities.Models;

namespace TestWebsite.DataAccess
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public override async Task<Product> GetByIdAsync(int? id)
        {
            return await context.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public override async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await context.Set<Product>()
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToListAsync();
        }
    }
}