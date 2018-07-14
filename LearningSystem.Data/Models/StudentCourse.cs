namespace LearningSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Core.GlobalConstants;

    public class StudentCourse
    {
        public string StudentId { get; set; }

        public User Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public Grade? Grade { get; set; }

        [MaxLength(ExamSubmissionLength)]
        public byte[] ExamSubmission { get; set; }
    }
}
