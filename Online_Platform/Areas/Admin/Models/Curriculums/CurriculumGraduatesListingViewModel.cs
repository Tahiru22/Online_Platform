namespace Online_Platform.Areas.Admin.Models.Curriculums
{
    using System.Collections.Generic;
    using Online_Platform.Services.Admin.Models.Curriculums;
    using Online_Platform.Services.Admin.Models.Users;

    public class CurriculumGraduatesListingViewModel
    {
        public AdminCurriculumBasicServiceModel Curriculum { get; set; }

        public IEnumerable<AdminDiplomaGraduateServiceModel> Graduates { get; set; }

        public IEnumerable<AdminUserListingServiceModel> Candidates { get; set; }
    }
}
