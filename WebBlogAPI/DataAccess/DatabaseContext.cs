using Microsoft.EntityFrameworkCore;
using WebBlogAPI.Models;

namespace WebBlogAPI.DataAccess
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options){}

        // Declare Table
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // identity increment
            modelBuilder.HasSequence<int>("OrderNumber", schema:"shared")
                        .StartsAt(0).IncrementsBy(1);

            modelBuilder.Entity<Member>().Property(m => m.MemberID)
                                         .HasDefaultValueSql("NEXT VALUE FOR shared.OrderNumber");

            // Declare Primary Key
            
            modelBuilder.Entity<Member>().HasKey(m => m.MemberID);
        }
    }
}