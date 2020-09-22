using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SzakyDekor.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Product name's lenght must be lower than 50 characters")]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(50)]
        public string ImagePath { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        [ForeignKey(nameof(ProductCategory))]
        public int CategoryId { get; set; }
    }
}
