using Microsoft.EntityFrameworkCore;

namespace Company.Function.Models
{
    public class UserDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info=False;Trusted_Connection=True;database=Poc;server=localhost\SQLEXPRESS;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMaster>().Property(p => p.Id);
        }

        public DbSet<UserMaster> UserItems { get; set; }
    }
}