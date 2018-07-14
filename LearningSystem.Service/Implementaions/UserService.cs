namespace LearningSystem.Service.Implementaions
{
    using AutoMapper.QueryableExtensions;
    using Data;
    using Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Models.Users;
    using OpenHtmlToPdf;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Core;
    using static Core.GlobalConstants;

    public class UserService : IUserService
    {
        private readonly LearningSystemDbContext db;

        public UserService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public async Task<UserProfileServiceModel> ByIdAsync(string id)
            => await this.db
                .Users
                .Where(u => u.Id == id)
                .ProjectTo<UserProfileServiceModel>(new { studentId = id })
                .FirstOrDefaultAsync();

        public async Task<IEnumerable<UserListingServiceModel>> FindByNameAsync(string term, int page)
            => await this.db
                .Users
                .Where(u => u.Name.ToLower().Contains(term.ToLower()))
                .Skip((page - 1) * UsersPageSize)
                .Take(UsersPageSize)
                .ProjectTo<UserListingServiceModel>()
                .ToListAsync();

        public async Task<int> TotalByNameAsync(string term)
            => await this.db
                .Users
                .Where(u => u.Name.ToLower().Contains(term.ToLower()))
                .CountAsync();

        public async Task<byte[]> GetCertificateAsync(int courseId, string studentId)
        {
            var studentInCourse = await this.db.FindAsync<StudentCourse>(studentId, courseId);
            if (studentInCourse == null) return null;

            var student = await this.db.Users.FirstOrDefaultAsync(u => u.Id == studentId);
            var course = await this.db.Courses.FirstOrDefaultAsync(c => c.Id == courseId);

            var certificateHtml = String.Format(GlobalConstants.Html,
                                        course.Name,
                                        course.StartDate.ToShortDateString(),
                                        course.EndDate.ToShortDateString(),
                                        student.Name,
                                        studentInCourse.Grade,
                                        await GetTrainerName(course.TrainerId),
                                        DateTime.UtcNow.ToShortDateString()
            );

            return Pdf.From(certificateHtml).Content();
        }

        private async Task<string> GetTrainerName(string studentId)
          => await this.db
                       .Users
                       .Where(u => u.Id == studentId)
                       .Select(u => u.Name)
                       .FirstOrDefaultAsync();
    }
}
