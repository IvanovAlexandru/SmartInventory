using System.Text.Json.Serialization;

namespace SmartInventoryApp.Models
{
    public class Warehouse
    {
        public int WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [JsonIgnore]
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; }
        /*public ICollection<InventoryLevel> InventoryLevels { get; set; }
        public ICollection<InventoryAlert> InventoryAlerts { get; set; }*/
    }
}
