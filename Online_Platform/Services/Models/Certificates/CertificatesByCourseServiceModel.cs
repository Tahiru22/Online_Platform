namespace Online_Platform.Services.Models.Certificates
{
    public class CertificatesByCourseServiceModel
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public IEnumerable<CertificateListingServiceModel> Certificates { get; set; }
    }
}
