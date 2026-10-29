using System.ComponentModel.DataAnnotations;

namespace APIGestionProductos.DTOs
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "El nombre es requerido.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El precio es requerido.")]
        [Range(0.01, 1000000000, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "La categoría es requerida.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "La disponibilidad es requerida.")]
        public bool IsAvailable { get; set; }
    }
}
