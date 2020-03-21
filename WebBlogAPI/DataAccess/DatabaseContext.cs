using Microsoft.EntityFrameworkCore;
using WebBlogAPI.Models;

namespace WebBlogAPI.DataAccess
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options){}

        // Declare Table
        public DbSet<Member> Members { get; set; }
        public DbSet<FirstTimesTextPage> FirstTimesTextPages {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // identity increment
            // declare auto increase column number
            modelBuilder.HasSequence<int>("OrderNumber", schema:"shared")
                        .StartsAt(0).IncrementsBy(1);

            // declare to each table use
            modelBuilder.Entity<Member>().Property(m => m.MemberID)
                                         .HasDefaultValueSql("NEXT VALUE FOR shared.OrderNumber");
            modelBuilder.Entity<FirstTimesTextPage>().Property(f => f.FTTP_ID)
                                         .HasDefaultValueSql("NEXT VALUE FOR shared.OrderNumber");


            // Declare Primary Key
            modelBuilder.Entity<Member>().HasKey(m => m.MemberID);
            modelBuilder.Entity<FirstTimesTextPage>().HasKey(f => f.FTTP_ID);
        }
    }
}