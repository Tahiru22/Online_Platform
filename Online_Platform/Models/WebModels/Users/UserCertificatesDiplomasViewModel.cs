namespace Online_Platform.Models.WebModels.Users
{
    using Online_Platform.Services.Models.Certificates;
    using Online_Platform.Services.Models.Users;
    using System.Collections.Generic;
   

    public class UserCertificatesDiplomasViewModel
    {
        public IEnumerable<CertificatesByCourseServiceModel> Certificates { get; set; }

        public IEnumerable<UserDiplomaListingServiceModel> Diplomas { get; set; }
    }
}
