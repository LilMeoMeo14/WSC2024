using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProject.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        [Column("ProductId")]
        public int ProductId { get; set; }
        [Column("ProductName")]
        public string ProductName { get; set; }

        [Column("Category")]
        public string Category { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }
        [Column("Cost")]
        public decimal Cost { get; set; }
        [Column("Description")]
        public string? Description { get; set; }
        [Column("Seasonal")]
        public bool Seasonal { get; set; }
        [Column("Active")]
        public bool Active { get; set; }
        [Column("IntroducedDate")]
        public DateTime IntroducedDate { get; set; }
        [Column("Ingredients")]
        public string? Ingredients { get; set; }
    }
}
