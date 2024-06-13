namespace Online_Platform.Services.Admin.Models.Curriculums
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using Online_Platform.Services.Admin.Models.Users;
    using System;
 

    public class AdminDiplomaGraduateServiceModel : IMapFrom<Diploma>
    {
        public string Id { get; set; }

        public DateTime IssueDate { get; set; }

        public int CurriculumId { get; set; }

        public AdminUserListingServiceModel Student { get; set; }
    }
}
