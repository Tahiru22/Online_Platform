namespace Online_Platform.Services.Admin
{
    using Online_Platform.Services.Admin.Models.Users;
    using System.Collections.Generic;
    using System.Threading.Tasks;
   

    public interface IAdminUserService
    {
        Task<IEnumerable<AdminUserListingServiceModel>> AllAsync();
    }
}
