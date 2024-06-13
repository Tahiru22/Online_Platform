using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Users
{
    public class UserBasicServiceModel : IMapFrom<User>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
