using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Users
{
    public class UserServiceModel : IMapFrom<User>
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }
    }
}
