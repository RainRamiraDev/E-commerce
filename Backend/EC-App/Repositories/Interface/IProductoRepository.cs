using EC_App.Models;
using System.Threading;

namespace EC_App.Repositories.Interface
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Product>>GetAllAsync();

        Task<Product?> GetByIdAsync(int id);

        Task<Product> CreateAsync(Product producto);

        Task UpdateAsync(Product producto);

        Task<bool> DeleteAsync(int id);
    }
}
