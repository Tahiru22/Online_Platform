using AutoMapper;
using Online_Platform.Mapping;
using Online_Platform.Models;
using Online_Platform.Services.Models.Resources;


namespace Online_Platform.Services.Models.Courses
{

    public class CourseWithResourcesServiceModel : CourseServiceModel, IMapFrom<Course>, IHaveCustomMapping
    {
        public IEnumerable<ResourceServiceModel> Resources { get; set; }

        public void ConfigureMapping(IProfileExpression mapper)
            => mapper
            .CreateMap<Course, CourseWithResourcesServiceModel>()
            .ForMember(dest => dest.Resources,
                opt => opt.MapFrom(c => c.Resources
                .OrderBy(r => r.FileName)
                .Select(r => new ResourceServiceModel { Id = r.Id, FileName = r.FileName })
                .ToList()));
    }
}
