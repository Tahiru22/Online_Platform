namespace Online_Platform.Areas.Admin.Models.Curriculums
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using Online_Platform.Models.WebModels;
    using Online_Platform.Services.Admin.Models.Curriculums;
    using System.ComponentModel.DataAnnotations;
   

    public class CurriculumFormModel : IMapFrom<AdminCurriculumBasicServiceModel>
    {
        public int Id { get; set; } = int.MinValue; // Create

        [Required]
        [StringLength(DataConstants.CourseNameMaxLength,
            ErrorMessage = DataConstants.StringMaxLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(DataConstants.CourseDescriptionMaxLength,
            ErrorMessage = DataConstants.StringMaxLength)]
        public string Description { get; set; }

        public FormActionEnum Action { get; set; } = FormActionEnum.Create;
    }
}
