using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
         
        }

        public DbSet<Product> Products { get; set; }
    }
}
