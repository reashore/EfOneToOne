using EfOneToOne.Models;
using Microsoft.EntityFrameworkCore;

namespace EfOneToOne.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Server=localhost;Database=SchoolDB;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
//            modelBuilder.Entity<Student>()
//                .HasOne<StudentAddress>(student => student.Address)
//                .WithOne(address => address.Student)
//                .HasForeignKey<StudentAddress>(address => address.StudentId);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DbSet<Student> Students { get; set; }
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }}