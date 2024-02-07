using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApplication2.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
