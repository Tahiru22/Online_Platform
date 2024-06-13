using AutoMapper;
using Online_Platform.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Online_Platform.Services.Models.Courses
{
    public class CourseProfileMaxGradeServiceModel : IMapFrom<CourseProfileServiceModel>, IHaveCustomMapping
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CourseStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CourseEndDate { get; set; }

        public decimal? GradeBgMax { get; set; }

        public string CertificateId { get; set; }

        public void ConfigureMapping(IProfileExpression mapper)
            => mapper
            .CreateMap<CourseProfileServiceModel, CourseProfileMaxGradeServiceModel>()
            .ForMember(
                dest => dest.GradeBgMax,
                opt => opt.MapFrom(src =>
                    src.CertificateGrade != 0
                    ? src.CertificateGrade
                    : src.GradeBg));
    }
}
