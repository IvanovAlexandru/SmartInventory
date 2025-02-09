using System.Text.Json.Serialization;

namespace SmartInventoryApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [JsonIgnore]
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; }
        [JsonIgnore]
        public ICollection<OrderItem> OrderItems { get; set; }
        /*public ICollection<ProductDemandForecast> ProductDemandForecasts { get; set; }*/
    }
}
