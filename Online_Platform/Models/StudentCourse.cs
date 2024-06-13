using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Platform.Models
{

    public class StudentCourse
    {
        public string StudentId { get; set; }

        public User Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(DataConstants.GradeBgMinValue, DataConstants.GradeBgMaxValue,
            ErrorMessage = DataConstants.RangeMinMaxValues)]
        public decimal? GradeBg { get; set; }
    }
}
