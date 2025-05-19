using EC_App.Dto;

namespace EC_App.Service.Interface
{
    public interface IProductoService
    {
        Task<IEnumerable<ProductoMostrarDto>> GetAllAsync();

        Task<ProductoMostrarDto?> GetByIdAsync(int id);

        Task<ProductoLeerDto> CreateAsync(ProductoLeerDto dto);

        Task<bool> UpdateAsync(int id, ProductoLeerDto dto);

        Task<bool> DeleteAsync(int id);
    }
}
