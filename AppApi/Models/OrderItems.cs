using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppApi.Models
{

    public class OrderItems
    {

        public int OrderItemId { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Navigation
        public Products Product { get; set; }

        // goi toi san pham trong product
        public string ItemName => Product == null ? "" : Product.ProductName;
        // tinh gia phai tra
        public decimal TotalAmount => Quantity * Price;
    }
}
