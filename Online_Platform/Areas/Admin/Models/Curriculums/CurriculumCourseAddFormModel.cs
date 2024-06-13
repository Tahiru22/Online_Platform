namespace Online_Platform.Areas.Admin.Models.Curriculums
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CurriculumCourseAddFormModel
    {
        public int CurriculumId { get; set; }

        public int CourseId { get; set; }

        public IEnumerable<SelectListItem> Courses { get; set; }
    }
}
