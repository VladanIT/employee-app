using Employee.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee.API.Data
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<Employees> Employees { get; set; }
    }
}
