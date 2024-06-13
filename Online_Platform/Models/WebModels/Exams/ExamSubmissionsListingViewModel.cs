namespace Online_Platform.Models.WebModels.Exams
{
    using Online_Platform.Services.Models.Courses;
    using Online_Platform.Services.Models.Exams;
    using System.Collections.Generic;
   

    public class ExamSubmissionsListingViewModel
    {
        public IEnumerable<ExamSubmissionServiceModel> ExamSubmissions { get; set; }

        public CourseServiceModel Course { get; set; }
    }
}
