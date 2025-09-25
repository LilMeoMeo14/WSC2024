using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppApi.Models
{
    public class Orders
    {
        public int TransactionId { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; }

        public string PaymentMethod { get; set; }

        public string Channel { get; set; }

        public int? StoreId { get; set; }

        public int? PromotionId { get; set; }

        public decimal? DiscountAmount { get; set; }

        public Customers customers { get; set; }
        public List<OrderItems> OrderItems { get; set; } = new List<OrderItems>();

        public string CustomerName
        => customers == null ? "" : $"{customers.FirstName} {customers.LastName}";

    }
}
