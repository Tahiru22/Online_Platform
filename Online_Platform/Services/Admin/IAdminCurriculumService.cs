namespace Online_Platform.Services.Admin
{
    using Online_Platform.Services.Admin.Models.Curriculums;
    using Online_Platform.Services.Admin.Models.Users;
    using System.Collections.Generic;
    using System.Threading.Tasks;
   

    public interface IAdminCurriculumService
    {
        Task<bool> AddCourseAsync(int curriculumId, int courseId);

        Task<IEnumerable<AdminCurriculumServiceModel>> AllAsync();

        Task<int> CreateAsync(string name, string description);

        Task<bool> ExistsAsync(int id);

        Task<bool> ExistsCurriculumCourseAsync(int curriculumId, int courseId);

        Task<AdminCurriculumBasicServiceModel> GetByIdAsync(int id);

        Task<IEnumerable<AdminUserListingServiceModel>> GetEligibleCandidatesWithoutDiplomasAsync(int id);

        Task<IEnumerable<AdminDiplomaGraduateServiceModel>> GetDiplomaGraduatesAsync(int id);

        Task<bool> RemoveAsync(int id);

        Task<bool> RemoveCourseAsync(int curriculumId, int courseId);

        Task<bool> UpdateAsync(int id, string name, string description);
    }
}
