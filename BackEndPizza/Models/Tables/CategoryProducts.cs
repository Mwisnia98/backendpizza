using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndPizza.Models.Tables
{
    [Table("category_producs", Schema = "shop")]
    public class CategoryProducts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CategoryName  { get; set; }
    }
}
