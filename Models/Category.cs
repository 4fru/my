using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace fproject.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1,100)]
        [DisplayName("DisPlay Order")]
        public int DesplayOrder { get; set; }
    }
}
