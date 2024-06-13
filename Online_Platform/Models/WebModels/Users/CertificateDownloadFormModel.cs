namespace Online_Platform.Models.WebModels.Users
{
    public class CertificateDownloadFormModel
    {
        public string Id { get; set; }

        public FormActionEnum Action { get; set; } = FormActionEnum.Certificate; // Certificate or Diploma
    }
}
