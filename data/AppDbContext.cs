using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ECommerceApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define your database tables here
        public DbSet<Product> Products { get; set; }
    }


// public class ApplicationDbContext : IdentityDbContext<Microsoft.AspNetCore.Identity.IdentityUser>
// {
//     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//         : base(options)
//     {
//     }
// }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
