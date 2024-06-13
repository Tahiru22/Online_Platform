namespace Online_Platform.Areas.Admin.Models.Curriculums
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Online_Platform.Services.Admin.Models.Curriculums;

    public class CurriculumListingViewModel
    {
        public IEnumerable<AdminCurriculumServiceModel> Curriculums { get; set; }

        public IEnumerable<SelectListItem> CoursesSelectList { get; set; }
    }
}
