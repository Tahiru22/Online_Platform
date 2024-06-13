using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Certificates
{
    public class CertificateServiceModel : IMapFrom<Certificate>
    {
        public string Id { get; set; }

        public string CourseName { get; set; }

        public DateTime CourseStartDate { get; set; }

        public DateTime CourseEndDate { get; set; }

        public string StudentName { get; set; }

        public decimal GradeBg { get; set; }

        public string CourseTrainerName { get; set; }

        public DateTime IssueDate { get; set; }

        public string DownloadUrl { get; set; }
    }
}
