using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                
                Id = 2,
                Name = "camisa manga",
                Price = new decimal(19.9),
                Description = "camiseta sadasd adsdasd  dasda  asdsad ",
                CategoryName = "t-shirt",
                ImageURL = "https://picsum.photos/v2/list?page=2&limit=100"

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {

                Id = 3,
                Name = "camisa gola",
                Price = new decimal(19.9),
                Description = "camiseta sadasd adsdasd  dasda  asdsad ",
                CategoryName = "t-shirt",
                ImageURL = "https://picsum.photos/v2/list?page=2&limit=100"

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {

                Id = 4,
                Name = "camisa sem manga",
                Price = new decimal(19.9),
                Description = "camiseta sadasd adsdasd  dasda  asdsad ",
                CategoryName = "t-shirt",
                ImageURL = "https://picsum.photos/v2/list?page=2&limit=100"

            });
        }
    }
}
