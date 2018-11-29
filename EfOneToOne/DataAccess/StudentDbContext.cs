using EfOneToOne.Models;
using Microsoft.EntityFrameworkCore;

namespace EfOneToOne.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //const string connectionString = "Server=.\\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True";
            //const string connectionString = "Server=localhost;Database=SchoolDB;user=sa;pwd=BellinAdmin1";
            const string connectionString = "Server=localhost;Database=SchoolDB;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne<StudentAddress>(student => student.Address)
                .WithOne(address => address.Student)
                .HasForeignKey<StudentAddress>(address => address.AddressOfStudentId);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }}