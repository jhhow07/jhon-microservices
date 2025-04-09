using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 2,
                    Name = "Wireless Mouse",
                    Price = new decimal(29.99),
                    Description = "Ergonomic wireless mouse with adjustable DPI and silent clicks.",
                    ImageUrl = "https://picsum.photos/id/102/300/200",
                    CategoryName = "Electronics"
                },
                new Product
                {
                    Id = 3,
                    Name = "Mechanical Keyboard",
                    Price = new decimal(89.50),
                    Description = "RGB backlit mechanical keyboard with blue switches.",
                    ImageUrl = "https://picsum.photos/id/104/300/200",
                    CategoryName = "Electronics"
                },
                new Product
                {
                    Id = 4,
                    Name = "Water Bottle",
                    Price = new decimal(15.75),
                    Description = "1-liter stainless steel reusable water bottle.",
                    ImageUrl = "https://picsum.photos/id/1080/300/200",
                    CategoryName = "Accessories"
                },
                new Product
                {
                    Id = 5,
                    Name = "Noise Cancelling Headphones",
                    Price = new decimal(129.99),
                    Description = "Over-ear headphones with active noise cancellation and 30-hour battery life.",
                    ImageUrl = "https://picsum.photos/id/180/300/200",
                    CategoryName = "Audio"
                },
                new Product
                {
                    Id = 6,
                    Name = "Smartwatch",
                    Price = new decimal(199.99),
                    Description = "Fitness-focused smartwatch with heart rate monitoring and GPS.",
                    ImageUrl = "https://picsum.photos/id/249/300/200",
                    CategoryName = "Wearables"
                },
                new Product
                {
                    Id = 7,
                    Name = "Gaming Chair",
                    Price = new decimal(299.00),
                    Description = "Comfortable ergonomic gaming chair with lumbar support.",
                    ImageUrl = "https://picsum.photos/id/335/300/200",
                    CategoryName = "Furniture"
                },
                new Product
                {
                    Id = 8,
                    Name = "LED Desk Lamp",
                    Price = new decimal(39.90),
                    Description = "Adjustable LED desk lamp with touch control and USB charging port.",
                    ImageUrl = "https://picsum.photos/id/151/300/200",
                    CategoryName = "Home Office"
                },
                new Product
                {
                    Id = 9,
                    Name = "Backpack",
                    Price = new decimal(59.99),
                    Description = "Durable laptop backpack with multiple compartments and waterproof material.",
                    ImageUrl = "https://picsum.photos/id/1011/300/200",
                    CategoryName = "Accessories"
                },
                new Product
                {
                    Id = 10,
                    Name = "Portable Bluetooth Speaker",
                    Price = new decimal(49.99),
                    Description = "Compact wireless speaker with powerful sound and 10-hour battery life.",
                    ImageUrl = "https://picsum.photos/id/241/300/200",
                    CategoryName = "Audio"
                },
                new Product
                {
                    Id = 11,
                    Name = "Running Shoes",
                    Price = new decimal(120.00),
                    Description = "Lightweight and breathable running shoes for daily training.",
                    ImageUrl = "https://picsum.photos/id/21/300/200",
                    CategoryName = "Footwear"
                }
            );
        }

    }
}
