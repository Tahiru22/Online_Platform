using Online_Platform.Models.WebModels.Courses;
using Online_Platform.Services.Models.Users;

namespace Online_Platform.Models.WebModels.Trainers
{
    

    public class TrainerDetailsViewModel
    {
        public UserServiceModel Trainer { get; set; }

        public CoursePageListingViewModel Courses { get; set; }
    }
}
