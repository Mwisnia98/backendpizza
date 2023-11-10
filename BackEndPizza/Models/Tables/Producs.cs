using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndPizza.Models.Tables
{
    [Table("producs",Schema = "shop")]
    public class Producs
    {
        [Key]
        public int Key { get; set; }
        [Required(AllowEmptyStrings= false,ErrorMessage = "Cannot be null")]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public decimal Price { get; set; }
        public bool MainProduct { get; set; } = false;
        public int? CategoryProductId { get; set; }
        [ForeignKey(nameof(CategoryProductId))]
        public virtual CategoryProducts CategoryProducts { get; set; }
    }
}
