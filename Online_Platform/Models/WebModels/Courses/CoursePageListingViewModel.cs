namespace Online_Platform.Models.WebModels.Courses
{
    using Online_Platform.Services.Models.Courses;
    using System.Collections.Generic;
    

    public class CoursePageListingViewModel
    {
        public IEnumerable<CourseServiceModel> Courses { get; set; }

        public PaginationViewModel Pagination { get; set; }

        public SearchViewModel Search { get; set; }
    }
}
