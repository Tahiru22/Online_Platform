﻿namespace Online_Platform.Services.Admin.Models.Curriculums
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using Online_Platform.Services.Admin.Models.Courses;

    public class AdminCurriculumServiceModel : IMapFrom<Curriculum>, IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<AdminCourseBasicServiceModel> Courses { get; set; }

        public void ConfigureMapping(IProfileExpression mapper)
            => mapper.CreateMap<Curriculum, AdminCurriculumServiceModel>()
            .ForMember(
                dest => dest.Courses,
                opt => opt.MapFrom(src => src
                    .Courses
                    .Where(cc => cc.CurriculumId == src.Id)
                    .Select(c => c.Course)
                    .OrderBy(c => c.Name)
                    .ThenByDescending(c => c.StartDate)));
    }
}
