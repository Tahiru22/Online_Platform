namespace Online_Platform.Models.WebModels.Trainers
{
    using Online_Platform.Services.Models.Courses;
    using Online_Platform.Services.Models.Users;
    using System.Collections.Generic;
   

    public class StudentCourseGradeViewModel
    {
        public IEnumerable<StudentInCourseServiceModel> Students { get; set; }

        public CourseServiceModel Course { get; set; }
    }
}
