using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Certificates
{

    public class CertificateListingServiceModel : IMapFrom<Certificate>
    {
        public string Id { get; set; }

        public DateTime IssueDate { get; set; }

        public decimal GradeBg { get; set; }

        public string StudentId { get; set; }
    }
}
