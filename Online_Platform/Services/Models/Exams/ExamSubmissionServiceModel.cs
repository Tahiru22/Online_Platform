namespace Online_Platform.Services.Models.Exams
{
    using Online_Platform.Mapping;
    using Online_Platform.Models;
    using System;

    public class ExamSubmissionServiceModel : IMapFrom<ExamSubmission>
    {
        public int Id { get; set; }

        public DateTime SubmissionDate { get; set; }
    }
}
