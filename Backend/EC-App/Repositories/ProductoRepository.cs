using EC_App.Data;
using EC_App.Models;
using EC_App.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace EC_App.Repositories
{
    public class ProductoRepository : IProductoRepository
    {

        private readonly EcommerceDbContext _context;

        public ProductoRepository(EcommerceDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product producto)
        {
            _context.Products.Add(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var producto = await _context.Products.FindAsync(id);
            if (producto == null) return false;

            _context.Products.Remove(producto);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task UpdateAsync(Product producto)
        {
            _context.Products.Update(producto);
            await _context.SaveChangesAsync();
        }
    }
}
