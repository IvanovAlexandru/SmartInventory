﻿using System.Data;
using System.Text.Json.Serialization;

namespace SmartInventoryApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int RoleID { get; set; }
        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        public Role Role { get; set; }
    }
}
