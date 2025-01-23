using Microsoft.EntityFrameworkCore;
using ShoppingCart12.Models;

namespace ShoppingCart12.Repository
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
           
        }
        public DbSet<Category> Category { get; set; }
    }
}
