namespace ContosoUniversity.Models
{
    public class Student
    {
        //The ID property is the primary key column of the database table that corresponds to this class
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        //The Enrollments property is a navigation property.
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
