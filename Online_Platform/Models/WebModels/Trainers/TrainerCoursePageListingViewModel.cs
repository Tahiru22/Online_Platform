namespace Online_Platform.Models.WebModels.Trainers
{
    using Online_Platform.Models.WebModels.Courses;
    using Online_Platform.Services.Models.Courses;
    using System.Collections.Generic;
   

    public class TrainerCoursePageListingViewModel : CoursePageListingViewModel
    {
        public IEnumerable<CourseServiceModel> CoursesToEvaluate { get; set; }
    }
}
