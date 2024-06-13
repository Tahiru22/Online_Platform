namespace Online_Platform.Services.Admin.Models.Diplomas
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using System;
   

    public class AdminDiplomaServiceModel : IMapFrom<Diploma>
    {
        public string Id { get; set; }

        public DateTime IssueDate { get; set; }

        public int CurriculumId { get; set; }

        public string CurriculumName { get; set; }
    }
}
