using System.ComponentModel.DataAnnotations;
namespace QLSP.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(0, 999999)]
        public decimal Price { get; set; }

        [Range(0, 100000)]
        public int Stock { get; set; }
    }
}
