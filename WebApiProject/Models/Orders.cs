using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProject.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [Column("TransactionId")]
        public int TransactionId { get; set; }

        [Column("CustomerId")]
        public int CustomerId { get; set; }

        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        [Column("TotalAmount")]
        public decimal TotalAmount { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("PaymentMethod")]
        public string PaymentMethod { get; set; }

        [Column("Channel")]
        public string Channel { get; set; }

        [Column("StoreId")]
        public int? StoreId { get; set; }

        [Column("PromotionId")]
        public int? PromotionId { get; set; }

        [Column("DiscountAmount")]
        public decimal? DiscountAmount { get; set; }

        [ForeignKey("CustomerId")]
        public Customers customers { get; set; }

        [NotMapped]
        public string CustomerName
            => customers == null ? "" : $"{customers.FirstName} {customers.LastName}";
        public List<OrderItems> OrderItems { get; set; } = new List<OrderItems>();



    }
}
