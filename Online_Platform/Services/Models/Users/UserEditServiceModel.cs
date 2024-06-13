namespace Online_Platform.Services.Models.Users
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
    public class UserEditServiceModel : IMapFrom<User>
    {
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
    }
}
