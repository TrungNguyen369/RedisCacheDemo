using Microsoft.EntityFrameworkCore;
using RedisCacheDemo.Model;

namespace RedisCacheDemo.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) { }
        public DbSet<Product> Products
        {
            get;
            set;
        }
    }
}
