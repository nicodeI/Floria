using System.ComponentModel.DataAnnotations;

namespace Fiorella.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be positive.")]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
