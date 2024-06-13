using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Certificates
{
    public class CertificateDetailsListingServiceModel : CertificateListingServiceModel, IMapFrom<Certificate>
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }
    }
}
