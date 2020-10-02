using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductCatalogAPI.Models
{
    public class ProductCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
