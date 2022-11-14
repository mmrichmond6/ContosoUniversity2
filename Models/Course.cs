﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //This attribute allows entering the PK for the course rather than having the database generate it.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //Enrollments is a navigation property
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}