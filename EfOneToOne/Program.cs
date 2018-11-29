using EfOneToOne.DataAccess;
using EfOneToOne.Models;
using static System.Console;

namespace EfOneToOne
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            CreateOneToOneRelationship();
            WriteLine("Done");
            ReadKey();
        }

        private static void CreateOneToOneRelationship()
        {
            using (SchoolDbContext schoolDbContext = new SchoolDbContext())
            {
                StudentAddress studentAddress = new StudentAddress
                {
                    Address = "208 - 2255 West 8th Ave.", 
                    City = "Vancouver", 
                    Province = "BC", 
                    Country = "Canada"
                };

                schoolDbContext.StudentAddresses.Add(studentAddress);

                Student student = new Student
                {
                    Name = "Frank J. Reashore", 
                    Address = studentAddress
                };
                
                schoolDbContext.Students.Add(student);

                schoolDbContext.SaveChanges();
            }
        }    
    }
}