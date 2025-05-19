using EC_App.Models;

namespace EC_App.Dto
{
    public class ProductoLeerDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int? Stock { get; set; }

        public int? CategoryId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual Category? Category { get; set; }
    }
}
