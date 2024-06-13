namespace Online_Platform.Areas.Admin.Models.Users
{
    using System.Collections.Generic;
    using Online_Platform.Services.Admin.Models.Users;

    public class RoleWithUsersViewModel
    {
        public string Role { get; set; }

        public IEnumerable<AdminUserListingServiceModel> UsersInRole { get; set; }
    }
}
