erDiagram
      
"dbo.OrderItems" {
    int OrderItemID "PK"
          int OrderID "FK"
          int ProductID "FK"
          int Quantity ""
          decimal UnitPrice ""
          
}
"dbo.__EFMigrationsHistory" {
    nvarchar(150) MigrationId "PK"
          nvarchar(32) ProductVersion ""
          
}
"dbo.Products" {
    int ProductID "PK"
          nvarchar(-1) SKU ""
          nvarchar(-1) Category ""
          datetime2 CreatedAt ""
          nvarchar(-1) Description ""
          nvarchar(-1) ProductName ""
          decimal UnitPrice ""
          datetime2 UpdatedAt ""
          
}
"dbo.Roles" {
    int RoleID "PK"
          nvarchar(-1) RoleName ""
          
}
"dbo.Suppliers" {
    int SupplierID "PK"
          nvarchar(-1) SupplierName ""
          nvarchar(-1) ContactInfo ""
          datetime2 CreatedAt ""
          datetime2 UpdatedAt ""
          
}
"dbo.Warehouses" {
    int WarehouseID "PK"
          nvarchar(-1) WarehouseName ""
          nvarchar(-1) Location ""
          int Capacity ""
          datetime2 CreatedAt ""
          datetime2 UpdatedAt ""
          
}
"dbo.Users" {
    int UserID "PK"
          nvarchar(-1) Username ""
          nvarchar(-1) PasswordHash ""
          nvarchar(-1) FullName ""
          nvarchar(-1) Email ""
          int RoleID "FK"
          datetime2 CreatedAt ""
          
}
"dbo.Orders" {
    int OrderID "PK"
          datetime2 OrderDate ""
          int SupplierID "FK"
          nvarchar(-1) Status ""
          int CreatedBy ""
          
}
"dbo.InventoryTransactions" {
    int InventoryTransactionID "PK"
          int ProductID "FK"
          int WarehouseID "FK"
          nvarchar(-1) TransactionType ""
          int Quantity ""
          datetime2 TransactionDate ""
          int CreatedBy ""
          
}
      "dbo.OrderItems" }|--|| "dbo.Orders": "OrderID"
"dbo.OrderItems" }|--|| "dbo.Products": "ProductID"
"dbo.Users" }|--|| "dbo.Roles": "RoleID"
"dbo.Orders" }|--|| "dbo.Suppliers": "SupplierID"
"dbo.InventoryTransactions" }|--|| "dbo.Products": "ProductID"
"dbo.InventoryTransactions" }|--|| "dbo.Warehouses": "WarehouseID"
