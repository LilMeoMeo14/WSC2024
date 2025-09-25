using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppApi.Models
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MembershipStatus { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime LastPurchaseDate { get; set; }
        public decimal? TotalSpending { get; set; }
        public decimal? AverageOrderValue { get; set; }
        public string Frequency { get; set; }
        public string PreferredCategory { get; set; }
        public bool Churned { get; set; }
    }
}
