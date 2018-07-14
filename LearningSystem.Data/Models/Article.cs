﻿namespace LearningSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static Common.DataModelValidationConstants;

    public class Article
    {
        public int Id { get; set; }

        [Required]
        [MinLength(ArticleTitleMinLength)]
        [MaxLength(ArticleTitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(ArticleContentMinLength)]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }
    }
}
