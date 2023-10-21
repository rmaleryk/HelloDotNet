using HelloWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWebApi.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
