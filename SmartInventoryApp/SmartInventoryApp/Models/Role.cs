using System.Text.Json.Serialization;

namespace SmartInventoryApp.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        [JsonIgnore]
        public ICollection<User> Users { get; set; }
    }
}
