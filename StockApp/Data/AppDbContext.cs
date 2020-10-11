using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockApp.Models;

namespace StockApp.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Recieve> RecieveProducts { get; set; }
        public DbSet<Issue> IssueProducts { get; set; }
        public DbSet<Stock> StockProducts { get; set; }
        public DbSet<ProductPrefix> ProductsPrefix { get; set; }
        public DbSet<ProductSuffix> ProductsSuffix { get; set; }


    }
}
