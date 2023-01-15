using Ecommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Book>? Books { get; set; }
        public virtual DbSet<Author>? Authors { get; set; }
        public virtual DbSet<Publisher>? Publishers { get; set; }
        public virtual DbSet<ApplicationUser>? ApplicationUsers { get; set; }
        public virtual DbSet<Order>? Orders { get; set; }
        public virtual DbSet<OrderItem>? OrderItems { get; set; }
        public virtual DbSet<ShoppingCartItem>? ShoppingCartItems { get; set; }

    }
}