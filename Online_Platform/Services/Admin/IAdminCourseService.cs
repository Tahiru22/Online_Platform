namespace Online_Platform.Services.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Online_Platform.Services.Admin.Models.Courses;

    public interface IAdminCourseService
    {
        Task<IEnumerable<AdminCourseBasicServiceModel>> AllAsync();

        Task<int> CreateAsync(
            string name,
            string description,
            DateTime startDate,
            DateTime endDate,
            decimal price,
            string trainerId);

        Task<AdminCourseServiceModel> GetByIdAsync(int id);

        Task<bool> UpdateAsync(
            int id,
            string name,
            string description,
            DateTime startDate,
            DateTime endDate,
            decimal price,
            string trainerId);

        Task<bool> RemoveAsync(int id);
    }
}
