using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Exams
{
   

    public class ExamSubmissionDetailsServiceModel : ExamSubmissionServiceModel, IMapFrom<ExamSubmission>
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }
    }
}
