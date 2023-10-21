using Microsoft.EntityFrameworkCore;
using NetCoreCRUDTestv2.Models;

namespace NetCoreCRUDTestv2.Data
{
    public class testDbContext : DbContext
    {
        public testDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> MyProperty { get; set; }
    }
}
