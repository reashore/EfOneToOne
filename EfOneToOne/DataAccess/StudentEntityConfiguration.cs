using EfOneToOne.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfOneToOne.DataAccess
{
    public class StudentConfiguration: IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne<StudentAddress>(student => student.Address)
                .WithOne(address => address.Student)
                .HasForeignKey<StudentAddress>(address => address.AddressOfStudentId);
        }
    }}