using System.Text.Json.Serialization;

namespace SmartInventoryApp.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int SupplierID { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }

        [JsonIgnore]
        public Supplier Supplier { get; set; }
        [JsonIgnore]
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
