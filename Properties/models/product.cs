namespace ECommerceApp.Models
{
    public class Product
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty; // Product Name
        public decimal Price { get; set; } // Product Price
        public int Stock { get; set; } // Available Stock
    }
}
