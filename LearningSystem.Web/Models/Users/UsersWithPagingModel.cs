namespace LearningSystem.Web.Models.Users
{
    using Service.Models.Users;
    using System;
    using System.Collections.Generic;

    using static Core.GlobalConstants;

    public class UsersWithPagingModel
    {
        public int TotalUsers { get; set; }

        public int TotalPages =>
            (int)Math.Ceiling(this.TotalUsers / (double)UsersPageSize);

        public int CurrentPage { get; set; }

        public int PreviousPage => this.CurrentPage == 1
            ? 1
            : this.CurrentPage - 1;

        public int NextPage => this.CurrentPage == this.TotalPages
            ? this.TotalPages
            : this.CurrentPage + 1;

        public IEnumerable<UserListingServiceModel> Users { get; set; }
            = new List<UserListingServiceModel>();
    }
}
