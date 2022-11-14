namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    
    public class Enrollment
    {
        //The EnrollmentID is a primary key
        public int EnrollmentID { get; set; }
        //The CourseID is a foreign key
        public int CourseID { get; set; }
        //The StudentID property is a foreign key
        public int StudentID { get; set; }
        //The Grade property is an enum
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }


    }
}