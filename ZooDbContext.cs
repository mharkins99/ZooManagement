using Microsoft.EntityFrameworkCore;
using ZooManagement.Models;

namespace ZooManagement
{
    public class ZooDbContext : DbContext
    {        
        public ZooDbContext(DbContextOptions<ZooDbContext> options) : base(options) {}
        public DbSet<Animal> Animal { get; set; }



    }
}