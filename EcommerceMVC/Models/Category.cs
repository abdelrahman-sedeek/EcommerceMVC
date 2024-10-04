using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1,1000)]
        public int DisplayOrder { get; set; }
    }
}
