namespace Online_Platform.Models.WebModels.Trainers
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc;
    

    public class StudentCourseGradeFormModel
    {
        [Required]
        [HiddenInput]
        public string StudentId { get; set; }

        [HiddenInput]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Grade")]
        [Range(2, 6,
            ErrorMessage = DataConstants.RangeMinMaxValues)]
        public decimal? GradeBg { get; set; }
    }
}
