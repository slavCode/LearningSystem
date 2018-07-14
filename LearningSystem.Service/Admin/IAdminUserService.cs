namespace LearningSystem.Service.Admin
{
    using Core.Mapping;
    using Data.Models;
    using Models.Users;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAdminUserService : IMapFrom<User>
    {
        Task<IEnumerable<UserListingServiceModel>> AllAsync();
    }
}
