using Microsoft.EntityFrameworkCore;
using BasicRazorViewComponents.Models;
namespace BasicRazorViewComponents
{
    public class ApplicationDbContexts : DbContext
    {
        public ApplicationDbContexts(DbContextOptions<ApplicationDbContexts> options) : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Department> Department { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<UserDetails>().HasNoKey().ToView("UserDetails");
            modelBuilder.Entity<GroupByAddressDTO>().HasNoKey().ToView("GroupByAddressDTO");
            modelBuilder.Entity<TableRowCountDTO>().HasNoKey().ToView("TableRowCountDTO");
            base.OnModelCreating(modelBuilder);

        }
    }
}
