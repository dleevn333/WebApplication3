using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace WebApplication3.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Tên")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Giá")]
        [Range(1000,10000)]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Số lượng")]
        [Range(0,1000)]
        public int Stock { get; set; }
        [Required]
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
