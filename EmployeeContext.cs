using Microsoft.EntityFrameworkCore;
using WeeklyAssignment.Models;


namespace WeeklyAssignment
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"TrustServerCertificate=True;Server=localhost;Database=EmployeeDB;Trusted_Connection=True");

        }
    }
}
