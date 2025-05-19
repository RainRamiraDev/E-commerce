using AutoMapper;
using EC_App.Dto;
using EC_App.Models;
using EC_App.Repositories.Interface;
using EC_App.Service.Interface;
using System.Threading;

namespace EC_App.Service
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductoLeerDto> CreateAsync(ProductoLeerDto dto)
        {
            var productoModel = _mapper.Map<Product>(dto);
            var created = await _repository.CreateAsync(productoModel);
            return _mapper.Map<ProductoLeerDto>(created);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductoMostrarDto>> GetAllAsync()
        {
            var producto = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductoMostrarDto>>(producto);
        }

        public async Task<ProductoMostrarDto?> GetByIdAsync(int id)
        {
            var monster = await _repository.GetByIdAsync(id);
            return monster == null ? null : _mapper.Map<ProductoMostrarDto>(monster);
        }

        public async Task<bool> UpdateAsync(int id, ProductoLeerDto dto)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null) return false;

            _mapper.Map(dto, existing);
            await _repository.UpdateAsync(existing);
            return true;
        }
    }
}
