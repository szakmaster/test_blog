using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SzakyDekor.Models
{
    public class ProductCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
