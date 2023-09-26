using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Range(1, 100)]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
    }
}
