namespace WebApiProject.Models
{
    public class BakeryItem
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }

        public bool IsExpired()
        {
            return DateTime.Now > ExpirationDate;
        }

        public decimal GetTotalValue()
        {
            return Price * Quantity;
        }
    }
}
