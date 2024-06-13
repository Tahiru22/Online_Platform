using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Resources
{

    public class ResourceDetailsServiceModel : ResourceServiceModel, IMapFrom<Resource>
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }
    }
}
