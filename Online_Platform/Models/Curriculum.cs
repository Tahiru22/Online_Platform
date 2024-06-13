using System.ComponentModel.DataAnnotations;

namespace Online_Platform.Models
{
    public class Curriculum
    {
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.CourseNameMaxLength,
            ErrorMessage = DataConstants.StringMaxLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(DataConstants.CourseDescriptionMaxLength,
            ErrorMessage = DataConstants.StringMaxLength)]
        public string Description { get; set; }

        public ICollection<CurriculumCourse> Courses { get; set; } = new List<CurriculumCourse>();

        public ICollection<Diploma> Diplomas { get; set; } = new List<Diploma>();
    }
}
