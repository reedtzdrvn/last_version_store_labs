using System.Data.Entity;

namespace Markov.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Markov")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}
