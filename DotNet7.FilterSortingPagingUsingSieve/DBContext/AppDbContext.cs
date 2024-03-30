using DotNet7.FilterSortingPagingUsingSieve.Models;

namespace DotNet7.FilterSortingPagingUsingSieve.DBContext
{
    public class AppDbContext
    {
        public List<ProductModel> Products { get; } = new()
        {
            new ProductModel() { Id = 1, Name = "Mouse", Description = "Wireless Mouse", Price = 300 },
            new ProductModel() { Id = 2, Name = "Key Board", Description = "Wireless Key Board", Price = 340 },
            new ProductModel() { Id = 3, Name = "Speaker", Description = "JBL Speaker", Price = 200 },
            new ProductModel() { Id = 4, Name = "CPU", Description = "Server CPU", Price = 3400 },
            new ProductModel() { Id = 5, Name = "HeadPhone", Description = "JBL HeadPhone", Price = 110 },
            new ProductModel() { Id = 6, Name = "Desktop", Description = "LCD Desktop", Price = 1000 },
            new ProductModel() { Id = 7, Name = "Desk Lamp", Description = "Desk Lamp with battery", Price = 100 },
            new ProductModel() { Id = 8, Name = "Table Fan", Description = "Big Table Fan", Price = 130 },
            new ProductModel() { Id = 9, Name = "File Box", Description = "Office File Box", Price = 40 },
            new ProductModel() { Id = 10, Name = "Key Holder", Description = "Key Holder", Price = 10 },
            new ProductModel() { Id = 11, Name = "Books", Description = "Library Books", Price = 200 },
            new ProductModel() { Id = 12, Name = "Pen Stand", Description = "Pen Stand", Price = 10 },
            new ProductModel() { Id = 13, Name = "Land phone", Description = "Land phone", Price = 290 },
            new ProductModel() { Id = 14, Name = "Mobile phone", Description = "5G Mobile phone", Price = 4500 },
            new ProductModel() { Id = 15, Name = "Mac Book", Description = "Mac Book", Price = 2000 },
            new ProductModel() { Id = 16, Name = "Surface", Description = "MS Surface Pro", Price = 3400 },
            new ProductModel() { Id = 17, Name = "UPS", Description = "UPS", Price = 200 },
        };
    }
}