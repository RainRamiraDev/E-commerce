using EC_App.Dto;
using EC_App.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EC_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
           _productoService = productoService;
        }


        [HttpGet("/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var productos = await _productoService.GetAllAsync();
            return Ok(productos); // 200 OK con la lista
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var producto = await _productoService.GetByIdAsync(id);
            if (producto == null) return NotFound();
            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductoLeerDto dto)
        {
            var created = await _productoService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductoLeerDto dto)
        {
            var updated = await _productoService.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent(); // 204, operación exitosa sin contenido
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _productoService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
