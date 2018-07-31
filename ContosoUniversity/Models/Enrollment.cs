namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        // PK
        public int EnrollmentID { get; set; }

        // FK
        public int CourseID { get; set; }

        //FK
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        // navigation properties
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
