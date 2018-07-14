namespace LearningSystem.Service
{
    using Models.Users;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUserService
    {
        Task<UserProfileServiceModel> ByIdAsync(string id);

        Task<IEnumerable<UserListingServiceModel>> FindByNameAsync(string term, int page);

        Task<int> TotalByNameAsync(string term);

        Task<byte[]> GetCertificateAsync(int courseId, string studentId);
    }
}
