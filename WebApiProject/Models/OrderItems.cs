using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApiProject.Models;

public class OrderItems
{
    [Key]
    [Column("OrderItemId")]
    public int OrderItemId { get; set; }

    [Column("TransactionId")]
    public int TransactionId { get; set; }

    [Column("ProductId")]
    public int ProductId { get; set; }

    [Column("Quantity")]
    public int Quantity { get; set; }

    [Column("Price")]
    public decimal Price { get; set; }

    // Navigation property tới Product
    public Products Product { get; set; }
    public string ProductName => Product == null ? "" : Product.ProductName;

    // goi toi san pham trong product

    // Navigation property tới Order
    [ForeignKey("TransactionId")]
    public Orders orders { get; set; }
 
}
