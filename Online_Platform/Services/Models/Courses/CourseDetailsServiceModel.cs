using Online_Platform.Infrastructure.Extensions;
using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Courses
{
    public class CourseDetailsServiceModel : CourseServiceModel, IMapFrom<Course>
    {
        public string Description { get; set; }

        public string TrainerUsername { get; set; }

        public int StudentsCount { get; set; }

        public bool IsExamSubmissionDate
            => this.EndDate.IsToday();
    }
}
