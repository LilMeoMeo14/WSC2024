using WebApiProject.Models;

namespace WebApiProject.Services
{
    public class BakeryInventory
    {
        private readonly List<BakeryItem> _items;

        public BakeryInventory()
        {
            _items = new List<BakeryItem>();
        }

        public void AddItem(BakeryItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Item cannot be null");

            if (string.IsNullOrWhiteSpace(item.Name))
                throw new ArgumentException("Item name cannot be empty or whitespace");

            if (item.Price <= 0)
                throw new ArgumentException("Price must be greater than 0");

            if (item.Quantity < 0)
                throw new ArgumentException("Quantity cannot be negative");

            _items.Add(item);
        }

        public bool RemoveItem(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            var itemToRemove = _items.FirstOrDefault(item =>
                item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (itemToRemove != null)
            {
                return _items.Remove(itemToRemove);
            }

            return false;
        }

        public bool RemoveItems(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            var itemsToRemove = _items
                .Where(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!itemsToRemove.Any())
                return false;

            foreach (var item in itemsToRemove)
            {
                _items.Remove(item);
            }

            return true;
        }

        public decimal GetTotalValue()
        {
            return _items.Sum(item => item.GetTotalValue());
        }

        public int GetItemCount()
        {
            return _items.Count;
        }

        public BakeryItem? GetItem(string name)
        {
            return _items.FirstOrDefault(item =>
                item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<BakeryItem> GetExpiredItems()
        {
            return _items.Where(item => item.IsExpired()).ToList();
        }

        public List<BakeryItem> GetAllItems()
        {
            return new List<BakeryItem>(_items);
        }
    }
}
