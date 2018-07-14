namespace LearningSystem.Service
{
    using System.Threading.Tasks;

    public interface ISeederService
    {
        Task RolesAsync();

        Task UsersAsync();

        Task CoursesAsync();

        Task UsersInCourses();

        Task ArticlesAsync();
    }
}
