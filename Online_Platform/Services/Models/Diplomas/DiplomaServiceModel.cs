using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Diplomas
{

    public class DiplomaServiceModel : IMapFrom<Diploma>
    {
        public string Id { get; set; }

        public DateTime IssueDate { get; set; }

        public string StudentId { get; set; }

        public string StudentName { get; set; }

        public string CurriculumName { get; set; }

        public string DownloadUrl { get; set; }
    }
}
