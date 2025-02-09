using System.Text.Json.Serialization;

namespace SmartInventoryApp.Models
{
    public class InventoryTransaction
    {
        public int InventoryTransactionID { get; set; }
        public int ProductID { get; set; }
        public int WarehouseID { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CreatedBy { get; set; }

        [JsonIgnore]
        public Product Product { get; set; }
        [JsonIgnore]
        public Warehouse Warehouse { get; set; }
    }
}
