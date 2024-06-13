namespace Online_Platform.Models.WebModels.Users
{
    using Online_Platform.Services.Models.Users;
    using System.Collections.Generic;
    

    public class UserProfileViewModel
    {
        public UserProfileServiceModel User { get; set; }

        public IEnumerable<string> Roles { get; set; }
    }
}
