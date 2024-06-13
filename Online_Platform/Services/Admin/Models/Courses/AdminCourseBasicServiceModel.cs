namespace Online_Platform.Services.Admin.Models.Courses
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using System;
   

    public class AdminCourseBasicServiceModel : IMapFrom<Course>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }
    }
}
