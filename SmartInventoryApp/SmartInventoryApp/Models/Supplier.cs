using System.Text.Json.Serialization;

namespace SmartInventoryApp.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ContactInfo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }
    }
}
