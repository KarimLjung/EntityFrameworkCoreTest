using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(
            //    "Server = (localdb)\\mssqllocaldb; Database = TestDatabase; Trusted_Connection = True;");

            optionsBuilder.UseSqlServer(
                "Server = .\\SQLEXPRESS; Database = TestDatabase; Trusted_Connection = True;");

            
            base.OnConfiguring(optionsBuilder);
        }   

    }
}
