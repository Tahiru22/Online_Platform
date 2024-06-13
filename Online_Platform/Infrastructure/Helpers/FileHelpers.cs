namespace Online_Platform.Infrastructure.Helpers
{
    using Online_Platform.Models;
    using System;
    

    public class FileHelpers
    {
        public static string ExamFileName(string course, string student, DateTime submissionDate)
            => $"{course} - {student} - {submissionDate.ToLocalTime()}.{DataConstants.FileType}";
    }
}
