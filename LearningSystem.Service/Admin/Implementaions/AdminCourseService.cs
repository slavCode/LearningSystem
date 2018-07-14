namespace LearningSystem.Service.Admin.Implementaions
{
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;

    public class AdminCourseService : IAdminCourseService
    {
        private readonly LearningSystemDbContext db;

        public AdminCourseService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public async Task CreateAsync(string name,
            string description,
            DateTime endDate,
            DateTime startDate,
            string trainerId)
        {
            var trainerExists = await this.db.Users.AnyAsync(t => t.Id == trainerId);

            if (!trainerExists)
            {
                return;
            }

            var course = new Course
            {
                Name = name,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                TrainerId = trainerId
            };

            await this.db.AddAsync(course);
            await this.db.SaveChangesAsync();
        }
    }
}
