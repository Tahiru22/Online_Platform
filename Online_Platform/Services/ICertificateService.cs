using Online_Platform.Services.Models.Certificates;

namespace Online_Platform.Services
{

    public interface ICertificateService
    {
        Task<bool> CreateAsync(string trainerId, int courseId, string studentId, decimal gradeBg);

        Task<CertificateServiceModel> DownloadAsync(string certificateId);

        bool IsGradeEligibleForCertificate(decimal? gradeBg);

        Task<bool> RemoveAsync(string id, string trainerId, int courseId);
    }
}
