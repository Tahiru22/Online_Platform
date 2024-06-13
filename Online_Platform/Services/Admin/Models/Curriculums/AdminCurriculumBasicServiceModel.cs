using Online_Platform.Mapping;
using Online_Platform.Models;

namespace Online_Platform.Services.Admin.Models.Curriculums
{
   

    public class AdminCurriculumBasicServiceModel : IMapFrom<Curriculum>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
