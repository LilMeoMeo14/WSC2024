using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppApi.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public string? Description { get; set; }
        public bool Seasonal { get; set; }
        public bool Active { get; set; }
        public DateTime IntroducedDate { get; set; }
        public string? Ingredients { get; set; }
    }
}
