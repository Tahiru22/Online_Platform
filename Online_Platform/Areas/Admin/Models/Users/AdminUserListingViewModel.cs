namespace Online_Platform.Areas.Admin.Models.Users
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Online_Platform.Services.Admin.Models.Users;

    public class AdminUserListingViewModel
    {
        public IEnumerable<AdminUserListingServiceModel> Users { get; set; }

        public IEnumerable<RoleWithUsersViewModel> RolesWithUsersInRole { get; set; }

        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
