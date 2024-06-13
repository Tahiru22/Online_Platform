namespace Online_Platform.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Online_Platform.Services.Models.Certificates;
    using Online_Platform.Services.Models.Courses;
    using Online_Platform.Services.Models.Exams;
    using Online_Platform.Services.Models.Resources;
    using Online_Platform.Services.Models.Users;

    public interface IUserService
    {
        Task<bool> CanBeDeletedAsync(string id);

        Task<UserEditServiceModel> GetProfileToEditAsync(string id);

        Task<UserProfileServiceModel> GetProfileAsync(string id);

        Task<IEnumerable<CourseProfileMaxGradeServiceModel>> GetCoursesAsync(string id);

        IEnumerable<CertificatesByCourseServiceModel> GetCertificates(string id);

        Task<IEnumerable<UserDiplomaListingServiceModel>> GetDiplomasAsync(string id);

        IEnumerable<ExamsByCourseServiceModel> GetExams(string id);

        IEnumerable<ResourcesByCourseServiceModel> GetResources(string id);

        Task<bool> UpdateProfileAsync(string id, string name, DateTime birthdate);
    }
}
