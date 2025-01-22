using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart12.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [MaxLength(50)]
        [Required]
        [DisplayName("Category name")]
        public string Name { get; set; }
    }
}
