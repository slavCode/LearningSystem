﻿namespace LearningSystem.Service.Models.Users
{
    using AutoMapper;
    using Core.Mapping;
    using Data.Models;
    using System.Linq;

    public class StudentInCourseServiceModel : IMapFrom<User>, IHaveCustomMapping
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Grade? Grade { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            var courseId = default(int);
            mapper.CreateMap<User, StudentInCourseServiceModel>()
                .ForMember(s => s.Grade,
                    cfg => cfg.MapFrom(u => u.Courses
                                  .Where(c => c.CourseId == courseId)
                                  .Select(c => c.Grade)
                                  .FirstOrDefault()));
        }
    }
}
