using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Admin.Models.Users
{
   

    public class AdminUserListingServiceModel : IMapFrom<User>
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }
    }
}
