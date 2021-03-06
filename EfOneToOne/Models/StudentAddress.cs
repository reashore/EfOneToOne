namespace EfOneToOne.Models
{
    public class StudentAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}