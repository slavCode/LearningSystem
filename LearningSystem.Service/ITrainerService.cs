namespace LearningSystem.Service
{
    using Data.Models;
    using Models;
    using Models.Courses;
    using Models.Users;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITrainerService
    {
        Task<bool> IsTrainerInCourseAsync(string trainerId, int courseId);

        Task<int> TotalStudentsAsync(int courseId);

        Task<IEnumerable<TrainerCourseListingServiceModel>> CoursesAsync(string trainerId);

        Task<IEnumerable<StudentInCourseServiceModel>> StudentsAsync(int courseId, int page);

        Task<bool> GradeStudentAsync(string studentId, Grade grade, int courseId);

        Task<byte[]> DownloadExamAsync(string studentId, int courseId);

        Task<StudentAndCourseNamesServiceModel> GetNamesAsync(string studentId, int courseId);
    }
}
