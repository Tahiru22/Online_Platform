using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Models.Resources
{

    public class ResourceServiceModel : IMapFrom<Resource>
    {
        public int Id { get; set; }

        public string FileName { get; set; }
    }
}
