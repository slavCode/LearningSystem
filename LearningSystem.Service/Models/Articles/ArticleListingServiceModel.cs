﻿namespace LearningSystem.Service.Models.Articles
{
    using AutoMapper;
    using Core.Mapping;
    using Data.Models;
    using System;

    public class ArticleListingServiceModel : IMapFrom<Article>, IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string AuthorUsername { get; set; }

        public string Content { get; set; }

        public string Title { get; set; }

        public DateTime PublishDate { get; set; }

        public void ConfigureMapping(Profile mapper)
           => mapper.CreateMap<Article, ArticleListingServiceModel>()
                .ForMember(a => a.Author, cfg => cfg.MapFrom(a => a.Author.Name))
                .ForMember(a => a.AuthorUsername, cfg => cfg.MapFrom(a => a.Author.UserName));
    }
}
