using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProject.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Age")]
        public int Age { get; set; }
        [Column("Gender")]
        public string Gender { get; set; }
        [Column("PostalCode")]
        public string PostalCode { get; set; }
        [Column("Email")]
        public string Email { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("MembershipStatus")]
        public string MembershipStatus { get; set; }

        [Column("JoinDate")]
        public DateTime JoinDate { get; set; }

        [Column("LastPurchaseDate")]
        public DateTime LastPurchaseDate { get; set; }
        
        [Column("TotalSpending")]
        public decimal? TotalSpending {  get; set; }
        [Column("AverageOrderValue")]
        public decimal? AverageOrderValue { get; set; }
        [Column("Frequency")]
        public string Frequency { get; set; }
        [Column("PreferredCategory")]
        public string PreferredCategory { get; set; }
        [Column("Churned")]
        public bool Churned { get; set; }

    }
}
