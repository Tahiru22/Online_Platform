﻿using Online_Platform.Infrastructure.Extensions;
using Online_Platform.Mapping;
using Online_Platform.Models;
using System.ComponentModel.DataAnnotations;

namespace Online_Platform.Services.Models.Courses
{
    public class CourseServiceModel : IMapFrom<Course>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        public string TrainerId { get; set; }

        public string TrainerName { get; set; }

        public string TrainerUserName { get; set; }

        public int Duration
            => this.StartDate.DaysTo(this.EndDate);

        public TimeSpan RemainingTimeTillStart // in local time
            => this.StartDate.RemainingTimeTillStart();

        public bool CanEnroll
            => this.RemainingTimeTillStart.TotalSeconds > 0;

        public bool IsActive
            => this.StartDate <= DateTime.UtcNow && DateTime.UtcNow <= this.EndDate;

        public bool IsUpcoming
            => this.StartDate.IsUpcoming();

        public bool CanBeEvaluated // should be evaluated not later than 1 month after course end
            => this.EndDate.HasEnded()
            && !this.EndDate.AddDays(ServicesConstants.EvaluationPeriodInDays).HasEnded();
    }
}
