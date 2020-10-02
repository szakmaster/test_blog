using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCatalogAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Dimensions { get; set; }

        [Required]
        public string Details { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [ForeignKey("ProductCategory")]
        public int CategoryIdRef { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
