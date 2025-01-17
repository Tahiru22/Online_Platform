﻿using System.ComponentModel.DataAnnotations;

namespace Online_Platform.Models
{
    public class Resource
    {
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.ResourceNameMaxLength,
            ErrorMessage = DataConstants.StringMinMaxLength,
            MinimumLength = DataConstants.ResourceNameMinLength)]
        public string FileName { get; set; }

        [Required]
        public string FileUrl { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
